namespace ChainOfResponsibility
{
    public class Director : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 10000.0m)
            {
                System.Console.WriteLine($"{GetType().Name} approved request #{purchase.Number}");
            }

            // pass responsibility to the next higher-up in the chain
            else if (_successor != null)
            {
                _successor.ProcessRequest(purchase);
            }
        }
    }
}