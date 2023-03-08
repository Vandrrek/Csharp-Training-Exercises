namespace _13.HierarchicalInheritance
{
   internal class Program
   {
      static void Main(string[] args)
      {
         var account = new Account();
         account.GetBalance();


         var savingsAccount = new SavingsAccount();
         savingsAccount.GetBalance();
         savingsAccount.GetInterestEarned();

         var checkingAccount = new CheckingAccount();
         checkingAccount.GetBalance();
         checkingAccount.Withdraw();
      }
   }
}