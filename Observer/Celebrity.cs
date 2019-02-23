using System.Collections.Generic;

namespace Observer
{
    public class Celebrity : ICelebrity
    {
        private string _tweet;
        public string Name {get;set;}
        public IEnumerable<IFan> Fans {get;set;}
        public string Tweet 
        {
            get 
            {
                return _tweet;
            }
            set 
            {
                _tweet = value;

                foreach(var fan in Fans)
                {
                    fan.Update($"{Name} tweeted: {_tweet}");
                }
            }
        }
    }
}