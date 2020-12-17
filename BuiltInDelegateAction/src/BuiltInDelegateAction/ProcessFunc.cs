using System;
namespace BuiltInDelegateAction
{
    public class ProcessFunc
    {   
        public void ProcessFunc1(int x, int y, Func<int,int,int> func)
        {
               var result =  func(x,y);

               Console.WriteLine("Result is : "+result);
        }
    }
}