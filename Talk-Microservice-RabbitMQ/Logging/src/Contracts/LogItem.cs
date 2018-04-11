using System;

namespace FP.MdDevDays2018.Logging.Contracts
{
    public class LogItem
    {
        public DateTime Timestamp { get; set; }

        public String RemoteHost { get; set; }

        public Guid SessionId { get; set; }

        public string InstanceHost { get; set; }

        public RequestState State { get; set; }
    }
}
