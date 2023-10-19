string gender = "Kobieta";
string name = "Ewa";
var age = 33;

if (gender == "Kobieta" && age > 18)
{
   if (name == "Ewa" && age> 30)
    {
      Console.WriteLine( "Ewa lat 33");
   }
   else
    {
       Console.WriteLine("Kobieta poniżej 30 lat");
    }
}
else
{
    Console.WriteLine("Niepełnoletni Męzczyzna");
}