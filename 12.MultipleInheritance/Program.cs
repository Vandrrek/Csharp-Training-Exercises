namespace _12.MultipleInheritance
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

            var flexibleSavingsAccount = new FlexibleSavingsAccount();
            flexibleSavingsAccount.GetBalance();
            flexibleSavingsAccount.GetInterestEarned();
            flexibleSavingsAccount.PayHealthCareCost();
        }
    }
}