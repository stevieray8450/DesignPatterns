using System.Diagnostics;

namespace Observer
{
    public class Fan : IFan
    {
        public string Name {get;set;}
        public void Update(string tweet)
        {
            Debug.WriteLine(tweet);
        }
    }
}