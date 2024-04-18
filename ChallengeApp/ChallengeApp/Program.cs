/*
Zadanie domowe dzien 9
Program, ktory utworzy obiekt employee, ktoremu zostana przydzielone oceny z zakresu od 0 do 100,
a nastepnie sporzadzi i wyswietli statystyki ocen pracownika (ocena najwyzsza, najnizsza, srednia ocen).
 */

using ChallengeApp;

var employee = new Employee("Adam", "Kamizelich"); // Tworzenie pracownika Adam Kamizelich

// Dodawanie ocen dla pracownika
employee.AddGrade(13.57f);
employee.AddGrade(75.98f);
employee.AddGrade(5.89f);
employee.AddGrade(99.45f);
employee.AddGrade(98.1f);
employee.AddGrade(100);

// Wyswietlanie raportu w postaci: imienia i nazwiska pracownika, jego oceny maksymalnej, minimalnej oraz sredniej wszystkich jego ocen
var statistics = employee.GetStatistics();
Console.WriteLine($"Pracownik: {employee.Name} {employee.Surname}");
Console.WriteLine($"Srednia ocen: {statistics.Average:N2}");
Console.WriteLine($"Najnizsza ocena: {statistics.Min:N2}");
Console.WriteLine($"Najwyzsza ocena: {statistics.Max:N2}");