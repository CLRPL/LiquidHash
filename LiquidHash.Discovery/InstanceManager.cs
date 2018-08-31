using LiquidHash.Discovery.Data;
using System.Collections.Generic;

namespace LiquidHash.Discovery
{
    public class InstanceManager
    {
        public List<Instance> Instances { get; set; }
        public Instance ThisPCInstance { get; set; }

        public InstanceManager()
        {
            Instances = new List<Instance>();
        }
    }
}
