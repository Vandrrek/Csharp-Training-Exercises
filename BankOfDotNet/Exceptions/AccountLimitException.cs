namespace BankOfDotNet.Exceptions
{
    public class AccountLimitException : Exception
    {
        private int _numberOfAccounts;

        public AccountLimitException(string message, int numberofAccounts) : base(message)
        {
            NumberOfAccounts = numberofAccounts;
        }

        public int NumberOfAccounts
        {
            get => _numberOfAccounts;
            private set => _numberOfAccounts = value;
        }
    }
}
