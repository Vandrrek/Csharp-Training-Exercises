namespace _04.ClassSeparation;

public class Transaction
{
    private double _amount;
    private DateTime _timestamp;

    public Transaction(double amount, DateTime timestamp)
    {
        Amount = amount;
        Timestamp = timestamp;
    }

    public double Amount
    {
        get => _amount;
        private set => _amount = value;
    }

    public DateTime Timestamp
    {
        get => _timestamp;
        private set => _timestamp = value;
    }
}