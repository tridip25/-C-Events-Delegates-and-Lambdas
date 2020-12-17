using System;

namespace raisingEventExample2
{
  // m:  public delegate int WorkPerformedHandler(object sender , WorkPerformedEventArgs e);
    public class Worker
    {
    // n:   public event WorkPerformedHandler WorkPerformed;

    // you can use the below syntax instead of m and n 
        public event EventHandler<WorkPerformedEventArgs> WorkPerformed; // Both delegate and event in one syntax.. WorkPerformed is delegate as well as event .
        public event EventHandler WorkCompleted;

        public void DoWork(int hours , string workType)
        {
            for(int i=0 ; i<hours ; i++)
            {
                OnWorkPerformed( i + 1 , workType);
            }
            OnWorkCompleted();
        }

        protected virtual void OnWorkPerformed (int hours , string workType)
        {
           // p : var del = WorkPerformed as WorkPerformedHandler;

           // since you are using m and n ... so you have to use the code below and remove p 
            var del = WorkPerformed as EventHandler<WorkPerformedEventArgs>;
            if(del!=null)
            {
                del (this , new WorkPerformedEventArgs(hours, workType));
            }
        }

        
        protected virtual void OnWorkCompleted ()
        {
            var del = WorkCompleted as EventHandler;
            if(del!=null)
            {
                del (this , EventArgs.Empty);
            }
        }

    }
}