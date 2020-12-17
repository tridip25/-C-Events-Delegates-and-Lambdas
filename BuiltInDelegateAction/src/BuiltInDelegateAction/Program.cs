using System;

namespace BuiltInDelegateAction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Advantage : no declaration required (But action<T> doesnt return any value)
           //theoritically takes only one parameter , but this works too....
           Action<int , int> myAddAction = (x,y) => Console.WriteLine(x+y);

         //  myAddAction(5,6);

            var data = new ProcessAction();
            data.ProcessAction1(10,20,myAddAction);

            //Func<T> here it can return values too
            Func<int,int,int> funcAddDel = (x,y) => x+y;
            // var res = funcAddDel(5,6);
            // Console.WriteLine("Result is: "+res);
            
            var data1 = new ProcessFunc();
            data1.ProcessFunc1(10, 20, funcAddDel);

        }
    }
}
