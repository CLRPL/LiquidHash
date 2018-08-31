using System;

namespace LiquidHash.CoinApi
{
    [Serializable]
    public class CoinApiException : Exception
    {
        public CoinApiException(string message)
            : base(message)
        {
        }
    }
}
