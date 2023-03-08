namespace _05.BaseConstructors;

public class DebitCard
{
    private int? _pin;
    private int _cvc;
    private string _cardname;
    private string _cardnumber;

    public DebitCard(string cardname, string cardnumber)
    {
        this.Cardname = cardname;
        this.Cardnumber = cardnumber;
    }
    public DebitCard(string cardname, string cardnumber, int cvc)
    :this(cardname, cardnumber)
    {
        this.Cvc = cvc;        
    }
    public DebitCard(string cardname, string cardnumber, int? pin)
        :this(cardname, cardnumber)
    {
        this.Pin = pin;
    }

    public DebitCard(string cardname, string cardnumber, int? pin, int cvc)
        :this(cardname, cardnumber)
    {
        this.Cvc = cvc;
        this.Pin = pin;
    }

    public int? Pin
    {
        get => _pin;
        private set => _pin = value;
    }

    public int Cvc
    {
        get => _cvc;
        private set => _cvc = value;
    }

    public string Cardname
    {
        get => _cardname;
        private set => _cardname = value;
    }

    public string Cardnumber
    {
        get => _cardnumber;
        private set => _cardnumber = value;
    }
}