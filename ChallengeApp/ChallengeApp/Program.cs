/*
Zadanie domowe dzien 11
Stworz metode GetStatistics() przy uzyciu kazdej z petli
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
var statistics = employee.GetStatistics();
var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();

// Wyswietlanie raportu w postaci: imienia i nazwiska pracownika, jego oceny maksymalnej, minimalnej oraz sredniej wszystkich jego ocen
Console.WriteLine($"Pracownik: {employee.Name} {employee.Surname}");
Console.WriteLine("Petla: \t\t\tForeach\t\tFor\t\tDo While\tWhile");
Console.WriteLine("-----------------------------------------------------------------------------");
Console.WriteLine($"Srednia ocen: \t\t{statistics1.Average:N2}\t\t{statistics2.Average:N2}\t\t{statistics3.Average:N2}\t\t{statistics4.Average:N2}");
Console.WriteLine($"Najnizsza ocena: \t{statistics1.Min:N2}\t\t{statistics2.Min:N2}\t\t{statistics3.Min:N2}\t\t{statistics4.Min:N2}");
Console.WriteLine($"Najwyzsza ocena: \t{statistics1.Max:N2}\t\t{statistics2.Max:N2}\t\t{statistics3.Max:N2}\t\t{statistics4.Max:N2}");