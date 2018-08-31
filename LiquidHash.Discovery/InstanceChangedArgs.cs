using System;

namespace LiquidHash.Discovery
{
    public class InstanceChangedArgs : EventArgs
    {
        public Data.Instance Instance { get; set; }
    }
}
