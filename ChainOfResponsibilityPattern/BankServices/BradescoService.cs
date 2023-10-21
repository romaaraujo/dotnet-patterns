namespace ChainOfResponsibility.BankServices
{
    public class BradescoService : AbstractBankService
    {
        public override object Handle(object request)
        {
            if ((request as string) == "1")
            {
                return "Bradesco";
            }
            else
            {
                Console.WriteLine("Não é Bradesco");
                return base.Handle(request);
            }
        }
    }
}