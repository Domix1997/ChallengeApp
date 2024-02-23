
var name = "Dominik";
var sex = "Mężczyzna";
var age = 16;

if (sex == "Kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (sex == "Mężczyzna" && age < 18)
{
    Console.WriteLine("Niepelnoletni mężczyzna");
}