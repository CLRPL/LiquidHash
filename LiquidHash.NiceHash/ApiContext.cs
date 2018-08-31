using LiquidHash.NiceHash.Extensions;
using LiquidHash.MultipoolApi;
using LiquidHash.MultipoolApi.Data;
using LiquidHash.Utility.Net;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Linq;
using LiquidHash.Xgminer.Data;

namespace LiquidHash.NiceHash
{
    public class ApiContext : IApiContext
    {
        public IEnumerable<MultipoolInformation> GetMultipoolInformation(string userAgent = "")
        {
            WebClient client = new ApiWebClient();
            if (!string.IsNullOrEmpty(userAgent))
                client.Headers.Add("user-agent", userAgent);

            string apiUrl = GetApiUrl();

            string jsonString = client.DownloadString(apiUrl);

            JObject jsonObject = JObject.Parse(jsonString);
            jsonObject = jsonObject.Value<JObject>("result");

            JArray jsonArray = jsonObject.Value<JArray>("stats");

            List<MultipoolInformation> result = new List<MultipoolInformation>();

            foreach (JToken jToken in jsonArray)
            {
                MultipoolInformation multipoolInformation = new MultipoolInformation();
                if (multipoolInformation.PopulateFromJson(jToken))
                    result.Add(multipoolInformation);
            }

            MultipoolInformation btcInformation = result.Single(mpi => mpi.Algorithm.Equals(AlgorithmNames.SHA256));

            foreach (MultipoolInformation otherInformation in result)
            {
                KnownAlgorithm knownAlgorithm = KnownAlgorithms.Algorithms.Single(ka => ka.Name.Equals(otherInformation.Algorithm));
                otherInformation.Profitability = ((otherInformation.Price * knownAlgorithm.Multiplier) / btcInformation.Price) * PoolProfitability * 100;
            }

            return result;
        }

        private const double PoolProfitability = 1.05;

        public string GetApiUrl()
        {
            return String.Format(@"https://www.nicehash.com/api?method=stats.global.current");
        }

        public string GetInfoUrl()
        {
            return String.Format(@"https://nicehash.com/index.jsp?p=api");
        }

        public string GetApiName()
        {
            return "NiceHash.com";
        }
    }
}
