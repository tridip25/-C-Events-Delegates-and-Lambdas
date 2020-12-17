using System;

namespace singletonAndMediatorSimpleExample
{
    public class File2
    {
        public File2()
        {
            Mediator.GetInstance().myNameEvent += (s,e) => Console.WriteLine("Entered Message is : " +e.Name); 
        }

    }
}