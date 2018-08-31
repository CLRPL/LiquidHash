using System;

namespace LiquidHash.UX.Data
{
    public class RemotingEventArgs : EventArgs
    {
        public string IpAddress;
        public Remoting.Data.Transfer.Machine Machine;
    }
}
