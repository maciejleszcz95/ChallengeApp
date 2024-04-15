//Program ktory odwraca liczbe np. 1344 => 4431

int liczba = 1344;
int liczba2 = 0;

char[] tablicaCyfr = liczba.ToString().ToArray() as char[];
tablicaCyfr = tablicaCyfr.Reverse().ToArray();
liczba2 = int.Parse(tablicaCyfr);

Console.WriteLine($"Liczba wejsciowa: {liczba}\nLiczba odwrocona: {liczba2}");