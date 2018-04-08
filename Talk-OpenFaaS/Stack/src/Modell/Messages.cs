using System.Collections.Generic;

namespace FP.MdDevDays2018.MongoMessage.Modell
{
    public class Messages
    {
        public Messages()
        {
            Entries = new List<Message>();
        }

        public List<Message> Entries { get; }
    }
}
