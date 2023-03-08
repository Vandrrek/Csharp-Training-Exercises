namespace _04.ClassSeparation;

public class DebitCard
{
    private int _pin;
    private int _cvc;

    public DebitCard(int pin, int cvc)
    {
        Pin = pin;
        Cvc = cvc;
    }

    public int Pin
    {
        get => _pin;
        private set => _pin = value;
    }

    public int Cvc
    {
        get => _cvc;
        private set => _cvc = value;
    }
}