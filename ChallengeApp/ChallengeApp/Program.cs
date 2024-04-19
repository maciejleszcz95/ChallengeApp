/*
Zadanie domowe dzien 9
Program, ktory utworzy obiekt employee, ktoremu zostana przydzielone oceny z zakresu od 0 do 100,
a nastepnie sporzadzi i wyswietli statystyki ocen pracownika (ocena najwyzsza, najnizsza, srednia ocen).
 */

using ChallengeApp;

var employee = new Employee("Adam", "Kamizelich"); // Tworzenie pracownika Adam Kamizelich

// Tablice ocen pracownika
float[] ocenyFloat = { 10.34f, 40.5f, 50, 80 };
string[] ocenyString = { "45", "6000", "23", "Adam" };


// Dodawanie ocen dla pracownika
employee.AddGrade("Adam");
employee.AddGrade("2000");
employee.AddGrade(ocenyFloat);
employee.AddGrade(ocenyString);
employee.AddGrade("75.98");
employee.AddGrade((double)5.89f);


// Wyswietlanie raportu w postaci: imienia i nazwiska pracownika, jego oceny maksymalnej, minimalnej oraz sredniej wszystkich jego ocen
var statistics = employee.GetStatistics();
Console.WriteLine($"Pracownik: {employee.Name} {employee.Surname}");
Console.WriteLine($"Srednia ocen: {statistics.Average:N2}");
Console.WriteLine($"Najnizsza ocena: {statistics.Min:N2}");
Console.WriteLine($"Najwyzsza ocena: {statistics.Max:N2}");