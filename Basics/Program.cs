
class Program
{
    static void Main()
    {

        Console.WriteLine("sa");

        var selcukAccount = new BankAccount();
        selcukAccount.DepositMoney(50);
        Console.WriteLine($"Selçugun parası : {selcukAccount.DisplayBalance()}");
        selcukAccount.WithdrawMoney(25);
        Console.WriteLine($"Selçugun parası : {selcukAccount.DisplayBalance()}");


 

    }

    class BankAccount
    {
        private int Balance = 0;

        public void DepositMoney(int money)
        {
            Balance =+ money;
        }

        public void WithdrawMoney(int money)
        {
            Balance -= money;
        }

        public int DisplayBalance()
        {
            return Balance;
        }

    }



}