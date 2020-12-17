using System;

namespace EventAndDelegates
{
    public class NameEventArgs : System.EventArgs
    {
        public NameEventArgs(string name)
        {
            Name = name;
        }
        public string Name{get;set;}
    }
}