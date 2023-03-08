using BankOfDotNet.Exceptions;

namespace BankOfDotNet
{
    internal class Program
   {
      static void Main(string[] args)
      {
         try
         {
            //Create Bank
            var bank = new Bank("BankOfDotNetPROJECT");
            Customer customer;
            Account account;

            // TRY#01
            try
            {
               //Create Bank Customers
               bank.AddCustomer("Jane", "Doe");
               bank.AddCustomer("John", "Smith");
               Console.WriteLine(bank.ToString());
            }
            catch (CustomerLimitException cle)
            {
               Console.WriteLine($"Customer limit Exception: {cle.Message}");
               Console.WriteLine($"Customer Count: {cle.NumberOfCustomers}");

            }

            // TRY#02
            try
            {
               //Create Customer Account
               customer = bank.GetCustomer("Jane", "Doe");
               customer.AddAccount(new CheckingAccount(500.00, 500.00));
               customer.AddAccount(new SavingsAccount(1500.00, 0.01));


               customer = bank.GetCustomer("John", "Smith");
               //customer.AddAccount(bank.GetCustomer("Jane", "Doe").GetAccounts()
               //   .Where(a => a.GetType() == typeof(CheckingAccount))
               //   .First());

               customer.AddAccount(bank.GetCustomer("Jane", "Doe")
                  .GetAccounts()
                  .First(a => a.GetType() == typeof(CheckingAccount)));
            }
            catch (AccountLimitException ale)
            {
               Console.WriteLine($"Account limit Exception: {ale.Message}");
               Console.WriteLine($"Account Count: {ale.NumberOfAccounts}");
            }

            bank.GenerateReport();

            // *** Jane Doe's Transactions ***//
            Console.WriteLine();
            Console.WriteLine("Getting Jane Doe's Checking Account having Overdraft Protection");
            customer = bank.GetCustomer("Jane", "Doe");
            //account = customer.GetAccounts()
            //   .Where(a => a.GetType() == typeof(CheckingAccount)).First();

            account = customer
               .GetAccounts().First(a => a.GetType() == typeof(CheckingAccount));

            // TRY#03
            try
            {
               account.WithDraw(155.00);
               account.Deposit(23.50);
               account.WithDraw(48.75);
               account.WithDraw(450.00);
            }
            catch (OverDraftException odex)
            {
               Console.WriteLine($"Overdraft Exception: {odex.Message}");
               Console.WriteLine($"Overdraft Deficit: {odex.DeficitAmount}");
            }
            finally
            {
               Console.WriteLine($"Customer {customer.FirstName}, {customer.LastName} account details:");
               account.Display();
            }

            // *** John Smith's Transactions ***//
            Console.WriteLine();
            Console.WriteLine("Getting John Smith's Checking Account having Overdraft Protection");
            customer = bank.GetCustomer("John", "Smith");
            //account = customer.GetAccounts()
            //   .Where(a => a.GetType() == typeof(CheckingAccount)).First();
            account = customer
               .GetAccounts().First(a => a.GetType() == typeof(CheckingAccount));

            // TRY#04
            try
            {
               account.Deposit(155.00);
               account.WithDraw(755.00);
            }
            catch (OverDraftException odex)
            {
               Console.WriteLine($"Overdraft Exception: {odex.Message}");
               Console.WriteLine($"Overdraft Deficit: {odex.DeficitAmount}");
            }
            finally
            {
               Console.WriteLine($"Customer {customer.FirstName}, {customer.LastName} account details:");
               account.Display();
            }

            //Jane Doe's Transactions
            Console.WriteLine();
            Console.WriteLine("Getting Jane Doe's First Transferable Account");
            customer = bank.GetCustomer("Jane", "Doe");
            ITransferable transferableAccount = customer.GetFirstTransferableAccount();

            // TRY#05
            try
            {
               transferableAccount.Transfer(account, 1000.00);
            }
            catch (OverDraftException odex)
            {
               Console.WriteLine($"Overdraft Exception: {odex.Message}");
               Console.WriteLine($"Overdraft Deficit: {odex.DeficitAmount}");
            }
            finally
            {
               Console.WriteLine($"Customer {customer.FirstName}, {customer.LastName} account details:");
               account.Display();
            }

            bank.GenerateReport();
         }
         catch (Exception ex)
         {
            Console.WriteLine($"Bank Exception: {ex.Message}");
         }
      }
   }
}