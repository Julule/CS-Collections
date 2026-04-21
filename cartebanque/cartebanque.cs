#region MODULO carte bancaire
Console.WriteLine("Ecrire Iban, sans les 2 premiers chiffres, ni les deux derniers, et sans \"BE\" "); // equiv print
string Iban = Console.ReadLine();
long Iban2 = long.Parse(Iban);
long IbanModu = Iban2 % 97;

Console.WriteLine("Nombre de contrôle ?"); // equiv print
string NbControle = Console.ReadLine();
int NbControleInt = int.Parse(NbControle);

if (IbanModu == NbControleInt){
    Console.WriteLine("Accepté !");
}

else{
    Console.WriteLine("Refusé");
}

#endregion

#region BBAN

string entree = Console.ReadLine()!; // Le ! permet de normaliser la variable unused. Pas nécessaire.
string toCheck = entree[..10]; // pour récup les 10 premiers
// string controle = entree[2..]; // Les caractères à partir du 2ème, 0 inclus. 
string controle = entree[^2..]; // Les deux derniers caractères

if(long.Parse(toCheck) % 97 == int.Parse(controle))
{
    Console.WriteLine("Le BBAN est correct !");
}
else
{
    Console.WriteLine("Le BBAN est incorrect");
}

#endregion