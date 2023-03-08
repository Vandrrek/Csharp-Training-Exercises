using BankOfDotNet.Exceptions;

namespace BankOfDotNet
{
   public abstract class Account
   {
      protected Guid _accountId;
      protected double _balance;

      protected Account(double initialBalance)
      {
         AccountId = Guid.NewGuid();
         Balance = initialBalance;
      }

      protected Account(Guid accountId, double balance)
      {
         AccountId = accountId;
         Balance = balance;
      }

      public Guid AccountId
      {
         get => _accountId;
         protected set => _accountId = value;
      }

      public double Balance
      {
         get => _balance;
         protected set => _balance = value;
      }

      public abstract void Display();

      public virtual void Deposit(double amount)
      {
         _balance += amount;
      }

      public virtual void WithDraw(double amount)
      {
         if (amount <= _balance)
         {
            _balance -= amount;
         }
         else
         {
            throw new OverDraftException("Insufficient Funds", amount - _balance);
         }
      }

   }
}
