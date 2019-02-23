namespace Observer
{
    public interface IFan
    {
        string Name {get;set;}
        void Update(string tweet);
    }
}