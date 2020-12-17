using System;
namespace BuiltInDelegateAction
{
    public class ProcessAction
    {   
        public void ProcessAction1(int x, int y, Action<int,int> action)
        {
                action(x,y);
        }
    }
}