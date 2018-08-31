using System;

namespace LiquidHash.Utility.Net
{
    [Flags]
    public enum SubnetClass
    {
        A = 1 << 0,
        B = 1 << 1,
        C = 1 << 2
    }
}
