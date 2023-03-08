namespace _17.InterfacesAsArguments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account[] accounts = {new AutoAccount(), new CheckingAccount(), new SavingsAccount()};

            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] is  ITransferable a)
                {
                    TransferFunds(a);
                }
                else
                {
                    Console.WriteLine("Account is not transferable!");
                }
            }
        }
        static void TransferFunds(ITransferable account)
        {
            account.Transfer();
        }
    }
}