using ChallengeApp;

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
        Console.WriteLine("Podaj kolejna ocene pracownika (albo wprowadz \'q\' aby zakonczyc):");
    }
    else
    {
        Console.WriteLine("Podaj ocene pracownika:");
        isNext = true;
    }

    // Pobieranie wartosci od uzytkownika
    var input = Console.ReadLine();

    // Warunek wyjscia z petli
    if (input == "q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
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
