using System;

namespace FP.MdDevDays2018.Cluster.Contracts
{
    public class ClusterMessage
    {
        public string Message { get; set; }

        public string Host { get; set; }

        public DateTime Timestamep { get; set; }
    }
}
