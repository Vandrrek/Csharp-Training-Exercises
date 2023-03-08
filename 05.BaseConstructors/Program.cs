namespace _05.BaseConstructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var card1 = new DebitCard("Bob Smith","0000 1111 2222 3333");
            var card2 = new DebitCard("Jane Doe", "0000 1111 2222 3333", 123);
            var card3 = new DebitCard("Mark Jones", "0000 1111 2222 3333", null);
            var card4 = new DebitCard("Alice Brown", "0000 1111 2222 3333", 123, 1234);

            var account1 = new Account("Bob Smith", 10.00, card1);
            var account2 = new Account("Jane Doe", 20.00, card2, true);
            var account3 = new Account("Mark Jones", 30.00, card3, DateTime.Now);
            var account4 = new Account("Alice Brown", 40.00, card4, true,  new DateTime(2020, 1, 1));


        }
    }
}