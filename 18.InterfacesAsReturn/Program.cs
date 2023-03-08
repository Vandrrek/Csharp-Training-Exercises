namespace _18.InterfacesAsReturn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account[] accounts = {new AutoAccount(), new CheckingAccount(), new SavingsAccount()};

            ITransferable transferableAccount = GetFirstTransferableAccount(accounts);
            transferableAccount.Transfer();
        }
        static ITransferable GetFirstTransferableAccount(Account[] accounts)
        {
            foreach (Account account in accounts)
            {
                if (account is ITransferable a)
                {
                    return a;
                }
            }

            return null;
        }
    }
}