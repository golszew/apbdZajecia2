using Kontenery.Interfejsy;

namespace Kontenery.Kontenery;

public class ChlodniaKontener : Kontener
{
    public double Temperatura { get; set; }
    public Rodzaj_Produktu RodzajProduktu { get; set; }
    
    public ChlodniaKontener(double masaLadunku, double wysokosc, double glebokosc, double wagaWlasna, double maksymalnaLadownosc, RodzajKontenera rodzajKontenera, double temperatura, Rodzaj_Produktu rodzajProduktu) : base(masaLadunku, wysokosc, glebokosc, wagaWlasna, maksymalnaLadownosc, rodzajKontenera)
    {
        Temperatura = temperatura;
        RodzajProduktu = rodzajProduktu;
    }

    public void zaladuj(int masaLadunku, Rodzaj_Produktu rodzajProduktu)
    {
        if(masaLadunku + MasaLadunku>MaksymalnaLadownosc || RodzajProduktu != rodzajProduktu || (int)rodzajProduktu<(int)RodzajProduktu )
            Console.WriteLine("Operacja nie moze zostac zrealizowana");
        else
        {
            MasaLadunku += masaLadunku;
        }
    }

    public override void zaladuj(int masaLadunku)
    {
        Console.WriteLine("Prosze podac rodzaj produktu");
    }
}

