/*
Zadanie domowe dzien 6
1. Stworz klase Employee, w ktorej przechowasz imie, nazwisko, wiek oraz punkty pracownika w postaci liczb calkowitych
2. Stworz 3 pracownikow i kazdemu przydziel po 5 ocen z zakresu od 1 do 10
3. Napisz program, ktory wyszuka pracownika z najwyzsza liczba ocen, a nastepnie wyswietli jego dane oraz wynik 
 */
using ChallengeApp;

int ocena = 0, 
    najwyzszaOcena = 0,
    indeksPracownika = 0; // indeks przechowujacy numer najlepszego pracownika (z najwyzsza suma ocen)

// Tworzenie tablicy pracownikow
Employee[] pracownik = { new("Jan", "Kowalski", 54), new("Monika", "Stanecka", 23), new("Jacek", "Kupczynski", 45)};

// Nadawanie pracownikom ocen
pracownik[0].AddScore(1);
pracownik[0].AddScore(7);
pracownik[0].AddScore(3);
pracownik[0].AddScore(4);
pracownik[0].AddScore(8);

pracownik[1].AddScore(9);
pracownik[1].AddScore(10);
pracownik[1].AddScore(1);
pracownik[1].AddScore(7);
pracownik[1].AddScore(4);

pracownik[2].AddScore(5);
pracownik[2].AddScore(2);
pracownik[2].AddScore(8);
pracownik[2].AddScore(10);
pracownik[2].AddScore(5);

// Wyszukiwanie pracownika z najwieksza suma ocen
for (int i = 0; i < pracownik.Length; i++)
{
    ocena = pracownik[i].Result;
    if (ocena > najwyzszaOcena)
    {
        najwyzszaOcena = ocena;
        indeksPracownika = i;
    }
}

// Wyswietlenie danych i wyniku najlepszego pracownika (z najwieksza liczba sumy ocen)
Console.WriteLine($"Hurra najlepszym pracownikiem jest {pracownik[indeksPracownika].FirstName} " +
    $"{pracownik[indeksPracownika].LastName} lat {pracownik[indeksPracownika].Age} z wynikiem {najwyzszaOcena}");