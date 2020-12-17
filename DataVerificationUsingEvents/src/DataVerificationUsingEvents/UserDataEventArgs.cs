using System;

namespace DataVerificationUsingEvents
{
    public class UserDataEventArgs : System.EventArgs
    {
        public UserDataEventArgs(string name  , string pan, int age)
        {
            Name = name;
            Pan = pan;
            Age = age;
        }

        public string Name{get;set;}
        public string Pan{get;set;}
        public int Age{get;set;}
    }
}