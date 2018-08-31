using System;

namespace LiquidHash.Remoting.Broadcast
{
    public class PacketReceivedArgs : EventArgs
    {
        public string IpAddress { get; set; }
        public Packet Packet { get; set; }
    }
}
