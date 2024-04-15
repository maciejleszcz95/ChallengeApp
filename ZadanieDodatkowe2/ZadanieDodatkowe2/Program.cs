// Program ktory usunie zduplikowane elementy z tablicy
int[] tablica = { 1, 2, 3, 3, 4, 4, 4, 4, 6, 76, 77, 77, 7, 7, 4, 4, 57, 5, 5, 5, 57 };
List<int> tablica2 = new List<int>();
bool powtorzenie = false;

//Wyswietlenie tablicy z powtorzeniami oraz tworzenie tablicy bez powtorzen
Console.WriteLine("Tablica z powtorzeniami: ");
for (int i = 0; i < tablica.Length; i++)
{
    powtorzenie = false;
    Console.Write(tablica[i] + " ");
    for (int j = i + 1; j < tablica.Length; j++)
        if (tablica[i] == tablica[j])
        {
            powtorzenie = true;
        }

    if (!powtorzenie)
    {
        tablica2.Add(tablica[i]);
    }
}

//Wyswietlenie tablicy bez powtorzen
Console.WriteLine("\n Tablica bez powtorzen: ");
foreach (int element in tablica2)
{
    Console.Write(element + " ");
}