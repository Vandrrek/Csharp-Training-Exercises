namespace _04.ClassSeparation;

public class Statement
{
    private int _pages;
    private string _format;

    public Statement(int pages, string format)
    {
        Pages = pages;
        Format = format;
    }

    public int Pages
    {
        get => _pages;
        private set => _pages = value;
    }

    public string Format
    {
        get => _format;
        private set => _format = value;
    }
}