namespace _03.Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var account1 = new Account();
           var account2 = new Account(10.00);
           var account3 = new Account("C3", 20.00);


            Console.WriteLine($"{account1.Name} {account1.Balance}");
            Console.WriteLine($"{account2.Name} {account2.Balance}");
            Console.WriteLine($"{account3.Name} {account3.Balance}");

            var customer1 = new Customer();
            var customer2 = new Customer();

            customer2.AddAccount(new Account
            {
                Name = "A1",
                Balance = 10.00
            });
            customer2.AddAccount(new Account
            {
                Name = "A2",
                Balance = 20.00
            });
            customer2.AddAccount(new Account
            {
                Name = "A3",
                Balance = 30.00
            });

            Account largest = customer2.GetLargestAccount();

            Console.WriteLine($"{largest.Name} has a balance of {largest.Balance}");
        }
    }
}