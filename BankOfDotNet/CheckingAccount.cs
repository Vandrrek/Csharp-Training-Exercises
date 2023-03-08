using BankOfDotNet.Exceptions;

namespace BankOfDotNet
{
   public class CheckingAccount : Account
   {
      private double _overdraftBalance;

      public CheckingAccount(double initialBalance) : this(initialBalance, 0.0)
      { }
      public CheckingAccount(double initialBalance, double overdraftBalance) : base(initialBalance)
      {
         _overdraftBalance = overdraftBalance;
      }

      public override void Display()
      {
         Console.WriteLine($"Checking Account Id: {_accountId}");
         Console.WriteLine($"Checking Account Balance: {_balance}");
         Console.WriteLine($"Checking Account Overdraft Balance: {_overdraftBalance}");
      }
      public override void WithDraw(double amount)
      {
         if (_balance < amount)
         {
            double overdraftAmountRequired = amount - _balance;
            if (_overdraftBalance < overdraftAmountRequired)
            {
               throw new OverDraftException("Insufficient funds using Overdraft Protection", overdraftAmountRequired);
            }
            else
            {
               _balance = 0.00;
               _overdraftBalance -= overdraftAmountRequired;
            }
         }
         else
         {
            Balance -= amount;
         }
      }
   }
}
