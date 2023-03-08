namespace _07.EncapsulateFields
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var accountBad = new AccountBad("bad", 50.00);
            // !None EncapsulatedFields
            accountBad.minimumbalance = 200.00;
            accountBad.balance = 90.00;

            Console.WriteLine(accountBad.minimumbalance);
            Console.WriteLine(accountBad.balance);

            var accountGood = new AccountGood("good",50.00);
            // EncapsulatedFields
            //accountGood.minimumbalance not available to clients directly
            accountGood.Balance = 100.00;
            Console.WriteLine(accountGood.Balance);
        }
    }
}