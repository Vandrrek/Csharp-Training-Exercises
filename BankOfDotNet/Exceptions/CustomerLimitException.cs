namespace BankOfDotNet.Exceptions
{
    public class CustomerLimitException : Exception
    {
        private int _numberOfCustomers;

        public CustomerLimitException(string message, int numberOfCustomers) : base(message)
        {
            NumberOfCustomers = numberOfCustomers;
        }

        public int NumberOfCustomers
        {
            get => _numberOfCustomers;
            private set => _numberOfCustomers = value;
        }
    }
}
