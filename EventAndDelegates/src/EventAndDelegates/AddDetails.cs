using System;

namespace EventAndDelegates
{
    
    public class AddDetails
    {
        public event EventHandler<NameEventArgs> DataAdded;
        public void detailsAdd(string data)
        {
            var del = DataAdded as EventHandler<NameEventArgs>;
            if (del != null)
            {
                del (this , new NameEventArgs(data));
            }
        }   
    }
}