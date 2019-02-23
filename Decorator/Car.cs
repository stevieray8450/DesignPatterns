namespace Decorator 
{
    public abstract class Car 
    {
        public string Description {get;set;}

        public abstract string GetDescription();
        public abstract decimal GetPrice();
    }
}