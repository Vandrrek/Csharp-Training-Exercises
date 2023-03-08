namespace _20.AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var account = new Account(); not allowed as Account is ABSTRACT

            var checkingAccount = new CheckingAccount();
            checkingAccount.Display();
            checkingAccount.WithDraw(10.00);
            checkingAccount.Deposit(20.00);

            var savingsAccount = new SavingsAccount();
            savingsAccount.Display();
            savingsAccount.WithDraw(10.00);
            savingsAccount.Deposit(20.00);

        }
    }
}