string name = "Maciej"; // imie 
char sex = 'm'; // m - mezczyzna, f - kobieta
ushort age = 29;

// pierwsza instrukcja warunkowa
if (sex == 'f' && age < 30)
{
    Console.WriteLine("Kobieta ponizej 30 lat");
}
// druga instrukcja warunkowa
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
// trzecia instrukcja warunkowa
else if (sex == 'm' && age < 18)
{
    Console.WriteLine("Niepelnoletni mezczyzna");
}
