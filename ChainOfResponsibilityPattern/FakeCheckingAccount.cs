using ChainOfResponsibility.BankServices;

namespace ChainOfResponsibility
{
    public class FakeCheckingAccount
    {
        public int bankCode { get => 3; }
        public string number { get => "231313"; }
        public string agency { get => "0523"; }

        public string GetBankName(AbstractBankService bankService)
        {
            return bankService.Handle(bankCode.ToString()) as string ?? "Não encontrado";
        }
    }
}