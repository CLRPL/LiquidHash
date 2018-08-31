using System.Collections.Generic;

namespace LiquidHash.MultipoolApi
{
    public interface IApiContext
    {
        IEnumerable<Data.MultipoolInformation> GetMultipoolInformation(string userAgent = "");
        string GetApiUrl();
        string GetInfoUrl();
        string GetApiName();
    }
}
