using System;
using EasyNetQ;
using FP.MdDevDays2018.Cluster.Contracts;

namespace FP.MdDevDays2018.Cluster.Display
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IBus myBus = null;
            try
            {
                myBus.Subscribe<ClusterMessage>("ClusterSub", msg =>
                {
                    Console.WriteLine($"Receive from {msg.Host} at {msg.Timestamep}: {msg.Message}");
                });
                Console.WriteLine("Display started");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                myBus?.Dispose();
            }
            Console.ReadLine();

        }
    }
}
