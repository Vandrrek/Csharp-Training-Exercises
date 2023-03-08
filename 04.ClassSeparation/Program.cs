using System.Net.Http.Headers;

namespace _04.ClassSeparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var accounts = new List<Account>();

            string name = "myAccount";
            double balance = 10.00;
            int pin = 1234;
            int cvc = 456;
            int pages = 12;
            string format = "pdf";

            var transactions = new List<Transaction>();

            for (int i = 0; i < 10; i++)
            {
                double amount = Math.Round(10.00 * (new Random().NextDouble()),2);
                DateTime timestamp = DateTime.Now;
                transactions.Add(new Transaction(amount, timestamp));
            }

            var debitCard = new DebitCard(pin, cvc);
            var statement = new Statement(pages, format);

            accounts.Add(new Account(name, balance, debitCard, statement, transactions));

            string documentFormat = "pdf";

            if (documentFormat ==  "pdf")
            {
                accounts.Where(c => c.Statement.Format == "pdf" && c.Transactions.Any(t => t.Amount < 10.00))
                    .Select(c => c.Name)
                    .ToList()
                    .ForEach(Console.WriteLine);
            }
            else if(documentFormat == "txt")
            {
                accounts.Where(c => c.Statement.Format == "txt")
                    .Select(c => c.Name)
                    .ToList()
                    .ForEach(Console.WriteLine);
            }

        }
    }
} 