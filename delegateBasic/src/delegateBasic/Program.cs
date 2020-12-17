using System;

namespace delegateBasic
{
    public delegate void WorkPerformedHandler(int hours, WorkType workType);

    class Program
    {
        static void Main(string[] args)
        {
            var work = new WorkType();
            WorkPerformedHandler del1 = new WorkPerformedHandler(WorkPerformed1);
            WorkPerformedHandler del2 = new WorkPerformedHandler(WorkPerformed2);
            

            del1 += del2;  //both will get called....

            del1(5, work); //But the problem is same parameters will be send.....
          //  del2(10 , work);
        }

        static void WorkPerformed1(int hours ,  WorkType workType)
        {
            Console.WriteLine("WorkPerformed 1 called");
        }

        static void WorkPerformed2(int hours ,  WorkType workType)
        {
            Console.WriteLine("WorkPerformed 2 called");
        }


    }

    //Also the delegates methods can be used for returning datas to...  just use a return type
}
