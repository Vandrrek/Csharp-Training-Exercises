namespace _09.Validation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var account1 = new AccountGood("A1",200.00);
                Console.WriteLine("PASSED");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            try
            {
                var account2 = new AccountGood("",200.00);
                Console.WriteLine("PASSED");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            try
            {
                var account3 = new AccountGood(null,200.00);
                Console.WriteLine("PASSED");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                var account4 = new AccountGood("A1",90.00);
                Console.WriteLine("PASSED");
            }
            catch (Exception ex) { Console.WriteLine(ex.Message);  }
        }
    }
}