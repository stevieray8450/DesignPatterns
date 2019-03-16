using System.Collections.Generic;

namespace Mediator
{
    public class Chatroom : AbstractChatroom
    {
        private Dictionary<string, Participant> _participants = new Dictionary<string, Participant>();

        public override void Register(Participant participant) 
        {
            if (!_participants.ContainsValue(participant)) 
            {
                _participants[participant.Name] = participant;
            }

            participant.Chatroom = this;
        }

        public override void Send(string from, string to, string message)
        {
            var participant = _participants[to];

            if (participant != null) 
            {
                participant.Receive(from, message);
            }
        }
    }
}