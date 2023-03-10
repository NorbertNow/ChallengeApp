using System.ComponentModel.Design;
string name = "Ewa";
bool isWoman = true;
int age = 33;
if (age < 30)
{
    if (isWoman)
    {
        Console.WriteLine("Kobieta ponizej 30 lat");
    }
    else if (age < 18)
    {
        Console.WriteLine("Niepelnoletni Mezczyzna");
    }
    else
    {
        Console.WriteLine("Mezczyzna w wieku 18-30 lat");
    }
}
else if (name == "Ewa")
{
    if (age == 33)
    {
        Console.WriteLine(name + ", lat " + age);
    }
    else
    {
        Console.WriteLine(name + " powyzej 30 lat");
    }
}
else if (isWoman)
{
    Console.WriteLine("Kobieta powyzej 30 lat");
}
else
{
    Console.WriteLine("Mezczyzna powyzej 30 lat");
}
