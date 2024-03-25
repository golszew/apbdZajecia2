using Kontenery.Interfejsy;
using Kontenery.Wyjatki;

namespace Kontenery.Kontenery;

public class GazKontener : Kontener, IHazardNotifier
{
 
    public GazKontener(double masaLadunku, double wysokosc, double glebokosc, double wagaWlasna, double maksymalnaLadownosc, RodzajKontenera rodzajKontenera) : base(masaLadunku, wysokosc, glebokosc, wagaWlasna, maksymalnaLadownosc, rodzajKontenera)
    {
    }

    public override void oproznij()
    {
        MasaLadunku *= 0.05;
    }

    public override void zaladuj(int masaLadunku)
    {
        if (masaLadunku > MaksymalnaLadownosc)
            throw new OverfillException(informacjaTekstowa());
        else if(MasaLadunku != 0)
            Console.WriteLine(informacjaTekstowa());
        else
        {
            MasaLadunku = masaLadunku;
        }
    }

    public string informacjaTekstowa()
    {
        return "Próba wykonania niebezpiecznej operacji na kontenerze o numerze " + NumerSeryjny;
    }
}