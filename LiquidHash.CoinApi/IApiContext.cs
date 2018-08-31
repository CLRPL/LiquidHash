using System.Collections.Generic;

namespace LiquidHash.CoinApi
{
    public interface IApiContext
    {
        IEnumerable<Data.CoinInformation> GetCoinInformation(string userAgent = "");
        string GetApiUrl();
        string GetInfoUrl();
        string GetApiName();
    }
}
