namespace ChainOfResponsibility
{

    public class President : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 50000.0m)
            {
                System.Console.WriteLine($"{GetType().Name} approved request #{purchase.Number}");
            }
        }
    }
}