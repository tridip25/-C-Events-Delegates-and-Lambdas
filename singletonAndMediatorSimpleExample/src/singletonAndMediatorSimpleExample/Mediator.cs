using System;

namespace singletonAndMediatorSimpleExample
{
    public class Mediator
    {
        
        //event...
         public event EventHandler<NamesEventArgs> myNameEvent;

        //creating singleton.......
        private static Mediator _instance = new Mediator();

        private Mediator(){}

        public static Mediator GetInstance()
        {
            return _instance;
        }
        //done creating sigleton
        
        public void OnMessageEntered(string name)
        {
            var del = myNameEvent as EventHandler<NamesEventArgs>;
            if(del!=null)
            {
                del(this , new NamesEventArgs(name));
            }
        }



    }
}