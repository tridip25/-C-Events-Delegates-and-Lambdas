using System;

//Often we think that delegates is used just for events which is not actually true
// The below example illustrate the sceanario........

namespace ExampleOfDelegatesWithoutEvents
{
    public delegate int OperationDelegate(int x, int y);
    class Program
    {
       
        static void Main(string[] args)
        {

        OperationDelegate addDel = (x,y) => x + y;
        OperationDelegate subDel = (x,y) => x - y;
        OperationDelegate multiplyDel = (x,y) => x * y;
         //   var k = addDel(5,6);
           // Console.WriteLine(k);
           var data = new ProcessData();
           data.process(10,6,multiplyDel);
        }
    }
}