namespace _01.DefiningClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var account = new Account();
            account.Name = "A1";
            account.Balance = 10.00;
            //account.name = "B1";

            var account2 = new Account
            {
                Name = "A2",
                Balance = 20.00
            };

            var account3 = new Account
            {
                Name = "A3",
                Balance = 30.00
            };


        }


    }
}