using Kontenery.Interfejsy;
using Kontenery.Wyjatki;

namespace Kontenery.Kontenery;

public abstract class Kontener : IKontener
{
    public NumerSeryjny NumerSeryjny { get; set; }
    
    public double MasaLadunku { get; set; }

    public double Wysokosc { get; set; }

    public double Glebokosc { get; set; }

    public double WagaWlasna { get; set; }

    public double MaksymalnaLadownosc { get; set; }

    

    protected Kontener(double masaLadunku, double wysokosc, double glebokosc, double wagaWlasna, double maksymalnaLadownosc, RodzajKontenera rodzajKontenera)
    {
        MasaLadunku = masaLadunku;
        Wysokosc = wysokosc;
        Glebokosc = glebokosc;
        WagaWlasna = wagaWlasna;
        MaksymalnaLadownosc = maksymalnaLadownosc;
        NumerSeryjny = new NumerSeryjny(rodzajKontenera);
    }


    public virtual void oproznij()
    {
        throw new NotImplementedException();
    }

    public virtual void zaladuj(int masaLadunku)
    {
        if (masaLadunku > MaksymalnaLadownosc)
            throw new OverfillException();
        MasaLadunku = masaLadunku;
        
    }
}