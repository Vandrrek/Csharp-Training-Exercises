namespace BankOfDotNet.Exceptions
{
   public class OverDraftException : Exception
   {
      private double _deficitAmount;

      public OverDraftException(string message, double deficitAmount) : base(message)
      {
         DeficitAmount = deficitAmount;
      }


      public double DeficitAmount
      {
         get => _deficitAmount;
         private set => _deficitAmount = value;
      }


   }
}
