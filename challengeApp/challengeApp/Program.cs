string gender = "Mężczyzna";
string name = "Ewa";
var age = 17;

if (gender == "Kobieta" && age < 30)
{
    Console.WriteLine("Kobieta ma poniżej 30 lat");
}
else if (gender == "Kobieta" && name == "Ewa" && age== 33)
{
    Console.WriteLine( "Ewa, lat 33");
}
else if (gender == "Mężczyzna" && age < 18)
{
    Console.WriteLine("Mężczyzna jest niepełnoletni");
}
else 
 {
    Console.WriteLine("Brak odpowiedzi");
}