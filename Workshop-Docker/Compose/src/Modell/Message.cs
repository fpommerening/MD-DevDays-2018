using System;

namespace FP.MdDevDays2018.MongoMessage.Modell
{
    public class Message
    {
        public string UserName { get; set; }

        public string Content { get; set; }

        public DateTime Timestamp { get; set; }
    }
}
