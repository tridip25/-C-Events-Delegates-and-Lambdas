using System;

namespace raisingEventExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
          //  obj.DoWork(5, "easy");
            //worker.WorkPerformed += new EventHandler<WorkPerformedEventArgs>(Worker_WorkPerformed);
            worker.WorkPerformed += Worker_WorkPerformed;   //also this syntax can be used ...(upto you)
            worker.WorkCompleted += new EventHandler(Worker_WorkCompleted);
            worker.DoWork(8, "easy");
        }

        private static void Worker_WorkCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Worker is done");
        }

        static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        {
            Console.WriteLine("Hours worked: "+e.Hours + " " + e.WorkType);
        }
    }
}
