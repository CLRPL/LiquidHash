using System;

namespace LiquidHash.Xgminer
{
    public class LaunchFailedArgs : EventArgs
    {
        public string Reason { get; set; }
        public string CoinName { get; set; }
    }
}
