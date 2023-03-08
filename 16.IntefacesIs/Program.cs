namespace _16.IntefacesIs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account[] accounts = {new AutoAccount(), new CheckingAccount(), new SavingsAccount()};

            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] is  IAccount a)
                {
                    a.Display();
                }
                else
                {
                    Console.WriteLine("Account is not an IAccount, unable to display!");
                }
            }

        }
    }
}