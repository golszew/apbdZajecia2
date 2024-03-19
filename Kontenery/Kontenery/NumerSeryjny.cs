namespace Kontenery;

public class NumerSeryjny
{
    private static int numer = 0;

    public string kod;

    public NumerSeryjny(RodzajKontenera rodzajKontenera)
    {
        kod = "KON-" + rodzajKontenera + '-' + ++numer;
    }
}