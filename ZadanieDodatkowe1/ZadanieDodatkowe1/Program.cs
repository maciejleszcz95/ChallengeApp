// Program ktory wyswietli caly alfabet
char poczatek = 'a';
char koniec = 'z';
char znak = poczatek;


while (true)
{
    Console.Write(znak);
    znak++;
    if (znak > koniec)
    {
        break;
    }
}

