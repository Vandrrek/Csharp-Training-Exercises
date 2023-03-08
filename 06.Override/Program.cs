namespace _06.Override
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customerAccount = new Account();
            customerAccount.AddCheckingAccount(new Account("Bobs Checking 1", 40.00));
            customerAccount.AddCheckingAccount(new Account("Bobs Checking 2", 50.00));
            customerAccount.AddSavingAccount(new Account("Bobs Saving 1", 70.00));
            customerAccount.AddSavingAccount(new Account("Bobs Saving 2", 90.00));

            Console.WriteLine(customerAccount.ToString());
        }
    }
}