string name = "Ewa";
var sex = "Kobieta";
int age = 29;

if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (sex == "Kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (sex != "Kobieta" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
   