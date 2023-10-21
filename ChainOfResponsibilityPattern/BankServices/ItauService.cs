namespace ChainOfResponsibility.BankServices
{
    public class ItauService : AbstractBankService
    {
        public override object Handle(object request)
        {
            if ((request as string) == "3")
            {
                return "Itaú";
            }
            else
            {
                Console.WriteLine("Não é Itaú");
                return base.Handle(request);
            }
        }
    }
}