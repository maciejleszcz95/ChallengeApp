/*
Zadanie domowe dzien 6
1. Stworz klase Employee, w ktorej przechowasz imie, nazwisko, wiek oraz punkty pracownika w postaci liczb calkowitych
2. Stworz 3 pracownikow i kazdemu przydziel po 5 ocen z zakresu od 1 do 10
3. Napisz program, ktory wyszuka pracownika z najwyzsza liczba ocen, a nastepnie wyswietli jego dane oraz wynik 
 */
using ChallengeApp;

int score = 0, 
    highestScore = 0,
    employeeIndex = 0; // indeks przechowujacy numer najlepszego pracownika (z najwyzsza suma ocen)

// Tworzenie tablicy pracownikow
Employee[] employees = { new("Jan", "Kowalski", 54), new("Monika", "Stanecka", 23), new("Jacek", "Kupczynski", 45)};

// Nadawanie pracownikom ocen
employees[0].AddScore(1);
employees[0].AddScore(7);
employees[0].AddScore(3);
employees[0].AddScore(4);
employees[0].AddScore(8);

employees[1].AddScore(9);
employees[1].AddScore(10);
employees[1].AddScore(1);
employees[1].AddScore(7);
employees[1].AddScore(4);

employees[2].AddScore(5);
employees[2].AddScore(2);
employees[2].AddScore(8);
employees[2].AddScore(10);
employees[2].AddScore(5);

// Wyszukiwanie pracownika z najwieksza suma ocen
for (int i = 0; i < employees.Length; i++)
{
    score = employees[i].Result;
    if (score > highestScore)
    {
        highestScore = score;
        employeeIndex = i;
    }
}

// Wyswietlenie danych i wyniku najlepszego pracownika (z najwieksza liczba sumy ocen)
Console.WriteLine($"Hurra najlepszym pracownikiem jest {employees[employeeIndex].FirstName} " +
    $"{employees[employeeIndex].LastName} lat {employees[employeeIndex].Age} z wynikiem {highestScore}");