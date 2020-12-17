using System;

namespace DataVerificationUsingEvents
{
    public class Menu
    {
        public Data getMenuData()
        {
            var data = new Data();
           
                Console.WriteLine("Verify your Data");
                Console.WriteLine("Enter name :");
                data.Name = Console.ReadLine();
                Console.WriteLine("Enter PAN no :");
                data.Pan = Console.ReadLine();
                Console.WriteLine("Enter age :");
                var input = Console.ReadLine();
                data.Age = int.Parse(input);

            return data;
        }
    }
}