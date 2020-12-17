using System;

namespace basicRaisingEvent
{
    public delegate void WorkPerformedHandler(int hours, string workType);
    class Program
    {
        static void Main(string[] args)
        {
            Worker obj = new Worker();
            obj.DoWork(15,"Easy");
        }

        public class Worker
        {
            public event WorkPerformedHandler WorkPerformed;

            public virtual void DoWork(int hours, string workType)
            {
                 hours = 10;
                 workType = "moderate";
                OnWorkPerformed(hours, workType);
            }

            protected virtual void OnWorkPerformed(int hours ,string workType)
            {
                WorkPerformedHandler del = WorkPerformed as WorkPerformedHandler;
               // Console.WriteLine("hello");
                if(del != null)
                {
                    Console.WriteLine("hello");
                    del(hours , workType);
                }
            }
        }
    }
}
