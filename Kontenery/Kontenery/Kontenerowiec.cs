using Kontenery.Kontenery;

namespace Kontenery;

public class Kontenerowiec
{
    public LinkedList<Kontener> Konterenry {
        get;
        set;
    }

    public double Predkosc { get; set; }

    public int MaksymalnaIlosc { get; set; }

    public int AktualnaIlosc { get; set; }

    public double MaksymalnaMasaLadunku { get; set; }

    public double AktualnaMasaLadunku { get; set; }

    public Kontenerowiec(double predkosc, int maksymalnaIlosc, double maksymalnaMasaLadunku)
    {
        Predkosc = predkosc;
        MaksymalnaIlosc = maksymalnaIlosc;
        MaksymalnaMasaLadunku = maksymalnaMasaLadunku;
        Konterenry = new LinkedList<Kontener>();
        AktualnaIlosc = 0;
    }

    public void zaladujKontener(Kontener kontener)
    {
        double masaKontenera = kontener.MasaLadunku + kontener.WagaWlasna;
        
        if(masaKontenera+AktualnaMasaLadunku<=MaksymalnaMasaLadunku && AktualnaIlosc+1<=MaksymalnaIlosc)
        {
            Konterenry.AddLast(kontener);
            AktualnaMasaLadunku += masaKontenera;
            AktualnaIlosc++;
        }
        else
        {
            Console.WriteLine("Kontener o numerze " + kontener.NumerSeryjny + " nie zostal dodany.");
        }
        
    }

    public void zaladujListeKontenerow(List<Kontener> kontenery)
    {
        foreach (var kontener in kontenery)
        {
            if(!Konterenry.Contains(kontener))
                zaladujKontener(kontener);
            else
            {
                Console.WriteLine("Kontener o numerze " + kontener.NumerSeryjny + " znajduje sie juz na statku.");
            }
        }
    }

    public void usunKontener(Kontener kontener)
    {
        if (Konterenry.Remove(kontener))
        {
            Console.WriteLine("Poprawnie usunieto kontener o numerze " + kontener.NumerSeryjny.kod);
            AktualnaMasaLadunku -= kontener.MasaLadunku + kontener.WagaWlasna;
        }else
            Console.WriteLine("Wybrany kontener nie znajduje sie na statku");
        
    }

    public void rozladujKontner(Kontener kontener)
    {
        if(Konterenry.Contains(kontener))
            Konterenry.Find(kontener).Value.oproznij();
        else
        {
            Console.WriteLine("Brak wybranego kontenera");
        }
    }

    public void zamianaKontenera(Kontener kontener, String numer)
    {
        bool znaleziono = false;
        foreach (var kon in Konterenry)
        {
            if (kon.NumerSeryjny.kod.Equals(numer))
            {
                Konterenry.Remove(kon);
                Konterenry.AddLast(kontener);
                znaleziono = true;
                break;
            }
        }
        
        if(!znaleziono)
            Console.WriteLine("Nie znaleziono kontenera o podanym numerze.");
    }

    public void przeniesKontener(Kontenerowiec kontenerowiec, Kontener kontener)
    {
        usunKontener(kontener);
        kontenerowiec.zaladujKontener(kontener);
    }

    public override string ToString()
    {
        string napis = "";
        int i = 0;
        foreach (var kontener in Konterenry)
        {
            napis += ++i + ". " + kontener.ToString() + "\n";
        }
        return "(Predkosc Max=" + Predkosc + ", maksymalna liczba kontenerow " + MaksymalnaIlosc + ", maksymalna" +
               " masa=" + MaksymalnaMasaLadunku + ")" + "\n Dostepne kontenery : \n" + napis;
    }
}