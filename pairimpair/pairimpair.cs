Console.WriteLine("Hello, World!");


Console.WriteLine("Ecrire un chiffre"); // equiv print
string Chiffre = Console.ReadLine();
int Chiffreint = int.Parse(Chiffre);

if (Chiffreint/2 + Chiffreint/2 == Chiffreint) 
{
    Console.WriteLine("C'est un chiffre pair !");
}
else
{
    Console.WriteLine("C'est un chiffre impair !");
}