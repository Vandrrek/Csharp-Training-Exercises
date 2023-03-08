namespace _19.InterfacesArrays
{
    public class AutoAccount : Account, ITransferable
    {
        public void Transfer()
        {
            Console.WriteLine("Auto Transfer Completed...");
        }
    }
}
