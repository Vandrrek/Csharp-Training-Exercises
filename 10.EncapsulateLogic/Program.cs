namespace _10.EncapsulateLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var account1 = new AccountGood("A1", 200.00);
                Console.WriteLine(account1.AccountLevel);

                var account2 = new AccountGood("A2", 400.00);
                Console.WriteLine(account2.AccountLevel);

                var account3 = new AccountGood("A3", 600.00);
                Console.WriteLine(account3.AccountLevel);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}