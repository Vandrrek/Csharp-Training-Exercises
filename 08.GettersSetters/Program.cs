namespace _08.GettersSetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var accountGood = new AccountGood("A1",10.00);
            Console.WriteLine($"{accountGood.Name} - {accountGood.Balance}");

            accountGood.Name = "A1 MODIFIED";
            accountGood.Balance = 100.00;
            Console.WriteLine($"{accountGood.Name} - {accountGood.Balance}");

        }
    }
}