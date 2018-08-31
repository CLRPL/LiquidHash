using System;

namespace LiquidHash.Xgminer
{
    public class AuthenticationFailedArgs : EventArgs
    {
        public string Reason { get; set; }
    }
}
