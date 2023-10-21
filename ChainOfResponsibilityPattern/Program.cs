using ChainOfResponsibility;
using ChainOfResponsibility.BankServices;

var bradescoService = new BradescoService();
var safraService = new SafraService();
var itauService = new ItauService();

bradescoService.SetNext(safraService).SetNext(itauService);

var checkingAccount = new FakeCheckingAccount();

var myBankName = checkingAccount.GetBankName(bradescoService);
Console.WriteLine("Banco: " + myBankName);