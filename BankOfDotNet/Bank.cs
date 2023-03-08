using BankOfDotNet.Exceptions;

namespace BankOfDotNet
{
   public class Bank
   {
      private const int MAXCUSTOMERS = 10;
      private List<Customer> _customers;

      public string BankName { get; private set; }

      public int NumberOfCustomers => _customers.Count;


      public Bank(string bankName)
      {
         BankName = bankName;
         _customers = new List<Customer>();
      }


      public void AddCustomer(string firstName, string lastName)
      {
         if (_customers.Count < MAXCUSTOMERS)
         {
            _customers.Add(new Customer(firstName, lastName));
         }
         else
         {
            throw new CustomerLimitException("Maximum number of customers reached", _customers.Count);
         }
      }

      public Customer GetCustomer(string firstName, string lastName) => _customers.First(c => c.FirstName == firstName && c.LastName == lastName);

      public override string ToString() => $"Bank Name: {BankName} \nTotal Customers: {NumberOfCustomers}";

      public void GenerateReport()
      {
         Console.WriteLine("Customers Report:\n");
         for (int i = 0; i < 80; i++)
         {
            Console.Write("-");
         }

         foreach (Customer customer in _customers)
         {
            Console.WriteLine($"\nCustomer {customer.FirstName}, {customer.LastName}");

            foreach (Account account in customer.GetAccounts())
            {
               if (account is CheckingAccount)
               {
                  Console.WriteLine("--- Checking Account ---");
               }
               else if (account is SavingsAccount)
               {
                  Console.WriteLine("--- Savings Account ---");
               }
               else
               {
                  Console.WriteLine("Unknown Account Type");
               }

               Console.WriteLine($"Current Balance: {account.Balance}");
            }

            Console.WriteLine();
         }
      }
   }
}