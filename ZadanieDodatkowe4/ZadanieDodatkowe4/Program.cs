// Program sortujacy liczby w tablicy

int[] tablica = { 7, 5, 1, 9, 4, 2, 3, 6, 8 };
int bufor = 0;

// wyswietlenie tablicy nieposortowanej
Console.WriteLine("Tablica nieposortowana:");
foreach(int liczba in tablica)
{
    Console.Write(liczba + " ");
}

// sortowanie tablicy liczb rosnaco
for (int i = 0; i < tablica.Length; i++)
{
    for (int j = i + 1; j < tablica.Length; j++)
    {
        if(tablica[j] < tablica[i])
        {
            bufor = tablica[i];
            tablica[i] = tablica[j];
            tablica[j] = bufor;
        }
    }
}

// wyswietlenie tablicy posortowanej
Console.WriteLine("\nTablica posortowana:");
foreach (int liczba in tablica)
{
    Console.Write(liczba + " ");
}
