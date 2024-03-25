using Kontenery.Interfejsy;
using Kontenery.Wyjatki;

namespace Kontenery.Kontenery;

public class PlynyKontener : Kontener, IHazardNotifier
{

    public bool NiebezpiecznyLadunek { get; set; }
    public PlynyKontener(double masaLadunku, double wysokosc, double glebokosc, double wagaWlasna, double maksymalnaLadownosc, RodzajKontenera rodzajKontenera, bool niebezpiecznyLadunek) : base(masaLadunku, wysokosc, glebokosc, wagaWlasna, maksymalnaLadownosc, rodzajKontenera)
    {
        NiebezpiecznyLadunek = niebezpiecznyLadunek;
    }

    public override void zaladuj(int masaLadunku)
    {
        if (NiebezpiecznyLadunek)
        {
            if (masaLadunku > 0.5 * MaksymalnaLadownosc)
                throw new OverfillException(informacjaTekstowa());
            else
            {
                MasaLadunku = masaLadunku;
            }
        }
        else
        {
            if (masaLadunku > MaksymalnaLadownosc * 0.9)
            {
                throw new OverfillException(informacjaTekstowa());
            } 
        }
    }

    public string informacjaTekstowa()
    {
        return "Próba wykonania niebezpiecznej operacji na kontenerze o numerze " + NumerSeryjny;
    }
}