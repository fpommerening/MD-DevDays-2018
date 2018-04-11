using System;
using EasyNetQ;

namespace FP.MdDevDays2018.Basics.Connecting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
               // Console.WriteLine("Verbindung wurde aufgebaut: {0}", myBus.IsConnected);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Verbindung ist fehlgeschlagen");
                Console.WriteLine(ex);
            }
            finally
            {
            }
            Console.ReadLine();
        }
    }
}
