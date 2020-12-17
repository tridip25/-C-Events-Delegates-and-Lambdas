using System;

namespace singletonAndMediatorSimpleExample
{
    public class NamesEventArgs : System.EventArgs
    {
        public NamesEventArgs(string name)
        {
            Name = name;
        }
        public string Name{get;set;}
    }
}