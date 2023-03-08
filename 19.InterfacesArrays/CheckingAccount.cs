namespace _19.InterfacesArrays
{
    public class CheckingAccount : Account, IAccount, ITransferable
    {
        public void Display()
        {
            Console.WriteLine("Displaying Checking Account Info...");
        }

        public void Transfer()
        {
            Console.WriteLine("Checking Transfer Completed...");
        }
    }
}
