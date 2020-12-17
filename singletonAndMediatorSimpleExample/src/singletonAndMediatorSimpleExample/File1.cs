using System;

namespace singletonAndMediatorSimpleExample
{
    public class File1
    {
        public void EnterPressed()
        {
            Console.WriteLine("Enter the message to be send:");
            var message = Console.ReadLine();

        
            Mediator.GetInstance().OnMessageEntered(message);
        }
    }
}