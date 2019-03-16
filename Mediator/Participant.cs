using System;

namespace Mediator
{
    // Colleague "interface"; abstract colleague
    public class Participant
    {
        public string Name {get;set;}
        public AbstractChatroom Chatroom {get;set;}
        public void Receive(string from, string message) 
        {
            System.Console.WriteLine($"You've received a message from {from}: {Environment.NewLine}\t{message}");
        }

        public void Send(string to, string message)
        {
            Chatroom.Send(Name, to, message);
        }
    }
}
