namespace ChainOfResponsibility.BankServices
{
    public class SafraService : AbstractBankService
    {
        public override object Handle(object request)
        {
            if ((request as string) == "2")
            {
                return "Safra";
            }
            else
            {
                Console.WriteLine("Não é Safra");
                return base.Handle(request);
            }
        }
    }
}