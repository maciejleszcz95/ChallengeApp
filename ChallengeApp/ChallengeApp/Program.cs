/*
Zadanie domowe dzien 5
Program zliczajacy wystapienia cyfr w liczbie "number"
Wyswietlenie zawartosci w sposob zrozumialy dla uzytkownika wedlug wzory pokazanego ponizej ponizej
0 => 0
1 => 0
.
.
9 => 0
 
 */

int number = 4566; // liczba wejsciowa
string numberInString = number.ToString(); // rzutowanie liczby na tekst
char[] letters = numberInString.ToCharArray(); // zamiana tekstu na ciag znakow
int[] numbers = new int[10]; // tablica wystapienia kolejno liczb 0, 1, 2 .. 9

// zliczanie wystapien cyfr w podanej liczbie
foreach (char letter in letters)
{
    numbers[letter - '0']++;
}

// wyswietlanie wystapien cyfr w liczbie w postaci zrozumialej dla uzytkownika
int i = 0;
foreach (int x in numbers)
{
    Console.WriteLine($"{i} => {x}");
    i++;
}
