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
        MasaLadunku = 0;
    }

    public virtual void zaladuj(int masaLadunku)
    {
        if (masaLadunku > MaksymalnaLadownosc)
            throw new OverfillException();
        MasaLadunku = masaLadunku;
        
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Kontener kontener = (Kontener)obj;

        return NumerSeryjny.kod.Equals(kontener.NumerSeryjny.kod);
    }

    public override string ToString()
    {
        return "(Masa ladunku=" + MasaLadunku + ", Wysokosc=" + ", Waga wlasna=" + WagaWlasna +
               ", Glebokosc=" + Glebokosc + ", Numer Seryjny=" + NumerSeryjny.kod + ", Maksymalna Ladownosc=" +
               MaksymalnaLadownosc + ")";
    }
}