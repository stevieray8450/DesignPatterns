namespace ChainOfResponsibility 
{
    public class VicePresident : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 25000.0m)
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