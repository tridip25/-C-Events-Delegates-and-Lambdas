using System;

namespace EventAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Something :");
            var input = Console.ReadLine();
            var data = new AddDetails();
            
            data.DataAdded += data_Added_Handler;

            data.detailsAdd(input);
        }

        static void data_Added_Handler(object sender, NameEventArgs e)
        {
            Console.WriteLine("Data added: "+e.Name);
        }
    }
}
