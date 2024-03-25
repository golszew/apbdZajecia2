// See https://aka.ms/new-console-template for more information

using Kontenery;
using Kontenery.Kontenery;

// Stworzenie kontenera danego typu
Kontener kontener1 = new PlynyKontener(20, 13.5, 10, 1, 25, RodzajKontenera.Plyny, false);
Kontener kontener2 = new ChlodniaKontener(40, 15, 15, 2, 50, RodzajKontenera.Chlodniczy, -10, Rodzaj_Produktu.Lody);
Kontener kontener3 = new GazKontener(0, 8.5, 5, 0.5, 20, RodzajKontenera.Gaz);
// Załadowanie ładunku do danego kontenera
kontener3.zaladuj(10);
Console.WriteLine(kontener3);
// Załadowanie kontenera na statek
Kontenerowiec kontenerowiec = new Kontenerowiec(10, 300, 20000);
kontenerowiec.zaladujKontener(kontener1);
Console.WriteLine("Statek 1:" + kontenerowiec);
// Załadowanie listy kontenerów na statek
List<Kontener> kotenery = new List<Kontener> { kontener2, kontener3 };
kontenerowiec.zaladujListeKontenerow(kotenery);
Console.WriteLine("Statek 1:" + kontenerowiec);
//     Usunięcie kontenera ze statku
kontenerowiec.usunKontener(kontener1);
Console.WriteLine("Statek 1:" + kontenerowiec);
//     Rozładowanie kontenera
kontenerowiec.rozladujKontner(kontener2);
Console.WriteLine("Statek 1:" + kontenerowiec);
//     Zastąpienie kontenera na statku o danym numerze innym
//     kontenerem
kontenerowiec.zamianaKontenera(kontener1, kontener2.NumerSeryjny.kod);
Console.WriteLine("Statek 1:" + kontenerowiec);
// Możliwość przeniesienie kontenera między dwoma statkami
Kontenerowiec kontenerowiec1 = new Kontenerowiec(8, 500, 35000);
kontenerowiec.przeniesKontener(kontenerowiec1, kontener1);
Console.WriteLine("Statek 1:" + kontenerowiec);
Console.WriteLine("Statek 2:" + kontenerowiec1);
// Wypisanie informacji o danym kontenerze
//     Wypisanie informacji o danym statku i jego ładunku
    