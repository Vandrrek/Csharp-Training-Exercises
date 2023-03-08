using BankOfDotNet.Exceptions;

namespace BankOfDotNet
{
    public class Customer
    {
        private const int MAXAccounts = 2;
        private Guid _customerId;
        private string _firstName;
        private string _lastName;
        private List<Account> _accounts;

        public Customer()
        {
        }
        public Customer(string firstName, string lastName)
        {
           CustomerId = Guid.NewGuid();
           FirstName = firstName;
           LastName = lastName;
           _accounts = new List<Account>(MAXAccounts);

        }

        public Guid CustomerId
        {
            get => _customerId;
            private set => _customerId = value;
        }

        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }

        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }

        public List<Account> Accounts
        {
            get => _accounts;
            private set => _accounts = value;
        }

        public int NumberOfAccounts => _accounts.Count;
        
        public void AddAccount(Account account)
        {
            if (_accounts.Count < MAXAccounts)
            { 
               _accounts.Add(account);
            }
            else
            {
               throw new AccountLimitException("Maximum number of Accounts reached", _accounts.Count);
            }
        }

        public List<Account> GetAccounts() => _accounts;

        public ITransferable GetFirstTransferableAccount()
        {
            foreach (var account in _accounts)
            {
               if (account is ITransferable a)
               {
                  return a;
               }
            }
            return null!;
        }
    }
}
