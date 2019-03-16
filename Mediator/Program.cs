using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var chatroom = new Chatroom();

            var eddie = new Actor { Name = "Eddie" };
            var jennifer = new Actor { Name = "Jennifer" };
            var bruce = new Actor { Name = "Bruce" };
            var tom = new Actor { Name = "Tom" };
            var tony = new NonActor { Name = "Tony" };

            chatroom.Register(eddie);
            chatroom.Register(jennifer);
            chatroom.Register(bruce);
            chatroom.Register(tom);
            chatroom.Register(tony);

            tony.Send("Tom", "Hey Tom!");
            jennifer.Send("Bruce", "Teach me to act and I'll teach you to dance.");
            tom.Send("Tony", "teach me to sing!");

            Console.ReadKey();
        }
    }
}
