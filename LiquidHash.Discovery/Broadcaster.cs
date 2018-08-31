﻿using System.Net;

namespace LiquidHash.Discovery
{
    public class Broadcaster
    {
        public static void Broadcast(string verb, int fingerprint)
        {
            Sender.Send(IPAddress.Broadcast, verb, fingerprint);
        }
    }
}
