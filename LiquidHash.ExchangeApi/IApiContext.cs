using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiquidHash.ExchangeApi
{
    public interface IApiContext
    {
        IEnumerable<Data.ExchangeInformation> GetExchangeInformation();
        string GetApiUrl();
        string GetInfoUrl();
        string GetApiName();
    }
}
