namespace BankOfDotNet
{
   public class SavingsAccount : Account, ITransferable
   {
      private readonly double _interestRate;

      public SavingsAccount(double initialBalance, double interestRate) : base(initialBalance)
      {
         _interestRate = interestRate;
      }

      public override void Display()
      {
         Console.WriteLine($"Savings Account Id: {_accountId}");
         Console.WriteLine($"Savings Account Balance: {_balance}");
         Console.WriteLine($"Savings Account Interest Rate: {_interestRate}");
      }

      public void Transfer(Account to, double amount)
      {
         WithDraw(amount);
         to.Deposit(amount);
      }

      
   }
}
