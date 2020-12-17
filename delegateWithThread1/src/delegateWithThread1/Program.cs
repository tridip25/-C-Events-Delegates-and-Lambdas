using System;
using System.Threading;

namespace delegateWithThread1
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart myThreadStart = displayNames;
            Thread myThread = new Thread(myThreadStart);
            myThread.Start();
            Console.WriteLine("Hello"); //this will get executed first 
                                        //as the method is handled by the background thread
        }

        static void displayNames()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Displaying Names...");
            string[] names = {"Yam" , "Gam","Kam"};
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
