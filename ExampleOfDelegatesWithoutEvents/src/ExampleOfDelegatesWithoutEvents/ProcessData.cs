using System;

namespace ExampleOfDelegatesWithoutEvents
{
    public class ProcessData
    {
        public void process(int x,int y, OperationDelegate del)
        {
            var result = del(x,y);
            Console.WriteLine("Result is: "+result);
        }
    }
}