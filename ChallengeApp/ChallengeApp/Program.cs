/*
Zadanie domowe dzien 12 
Stworz dzialajaca aplikacje do oceny pracownika (jednego)
Stworz dzialajace testy jednostkowe wraz ze sprawdzeniem liter A/B/C
Wrzuc dzialajacy kod na gita
 */

using ChallengeApp;
using System.Diagnostics;

// Powitanie
Console.WriteLine("Witamy w Programie XYZ do oceny Pracownikow");
Console.WriteLine("============================================\n");

// Tworzenie obiektu oraz zmiennych
var employee = new Employee();
bool isNext = false;


// Obsluga interfejsu uzytkownika
while (true)
{

    // Wyswietlenie odpowiedniego komunikatu gdy uzytkownik podaje pierwsza ocene czy kolejne
    if (isNext)
    {
        Console.WriteLine("Podaj kolejna ocene pracownika (albo wprowadz \"q\" aby zakonczyc):");
    }
    else
    {
        Console.WriteLine("Podaj ocene pracownika:");
        isNext = true;
    }

    var input = Console.ReadLine(); // Pobieranie wartosci od uzytkownika

    // Warunek wyjscia z petli
    if (input == "q")
    {
        break;
    }

    // Jesli input jest jednym znakiem oraz litera
    if (char.TryParse(input, out char result) && char.IsLetter(result))
    {
        employee.AddGrade(result);
    }
    else // W innym przypadku input jest string
    {
        employee.AddGrade(input);
    }

}

// Wyswietlanie statystyk
var statistics = employee.GetStatistics();
Console.WriteLine("\nStatystyki ocen pracownika");
Console.WriteLine("============================================\n");
Console.WriteLine($"Srednia ocena (litera):\t{statistics.AverageLetter}");
Console.WriteLine($"Srednia ocena:\t\t{statistics.Average.ToString("N2")}");
Console.WriteLine($"Najnizsza ocena:\t{statistics.Min.ToString("N2")}");
Console.WriteLine($"Najwyzsza ocena:\t{statistics.Max.ToString("N2")}");
