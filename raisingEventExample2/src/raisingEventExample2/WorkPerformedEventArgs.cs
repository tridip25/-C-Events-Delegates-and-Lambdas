using System;

namespace raisingEventExample2
{
    public class WorkPerformedEventArgs : System.EventArgs
    {
        public WorkPerformedEventArgs(int hours , string workType)
        {
            Hours = hours;
            WorkType = workType;
        }
        public int Hours{get;set;}
        public string WorkType {get;set;}
    }
}