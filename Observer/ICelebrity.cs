using System.Collections.Generic;

namespace Observer
{
    public interface ICelebrity
    {
        string Name {get;set;}
        string Tweet {get;set;}
        IEnumerable<IFan> Fans {get;set;}
    }
}