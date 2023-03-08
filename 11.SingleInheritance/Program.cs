namespace _11.SingleInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new Account();
            account.GetBalance();


            var savingsAccount = new SavingsAccount();
            savingsAccount.GetBalance();
            savingsAccount.GetInterestEarned();
        }
    }
}