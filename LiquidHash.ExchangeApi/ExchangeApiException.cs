using System;

namespace LiquidHash.ExchangeApi
{
    [Serializable]
    public class ExchangeApiException : Exception
    {
        public ExchangeApiException(string message)
            : base(message)
        {
        }
    }
}
