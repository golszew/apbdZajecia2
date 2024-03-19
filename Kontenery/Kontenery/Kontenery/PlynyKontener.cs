namespace Kontenery.Kontenery;

public class PlynyKontener : Kontener
{
    public PlynyKontener(double masaLadunku, double wysokosc, double glebokosc, double wagaWlasna, double maksymalnaLadownosc, RodzajKontenera rodzajKontenera) : base(masaLadunku, wysokosc, glebokosc, wagaWlasna, maksymalnaLadownosc, rodzajKontenera)
    {
        
    }

    public override void zaladuj(int masaLadunku)
    {
        base.zaladuj(masaLadunku);
    }
}