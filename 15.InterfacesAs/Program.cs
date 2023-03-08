namespace _15.InterfacesAs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new Account();
            IAccount account2 = account as IAccount;

            if (account2 != null)
            {
                account2.Display();
            }
            else
            {
                Console.WriteLine("Unable to display account info!");
            }

            var checkingAccount = new CheckingAccount();
            IAccount checkingAccount2 = checkingAccount as IAccount;

            if (checkingAccount2 != null)
            {
                checkingAccount2.Display();
            }
            else
            {
                Console.WriteLine("Unable to display CheckingAccount info!");
            }

            ;
        }
    }
}