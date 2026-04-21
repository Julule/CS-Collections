using System.Runtime.Intrinsics.X86;
// EXOS 
//Calculer le factoriel d’un nombre entré au clavier.
//Grâce à une boucle « for », calculez les x premiers nombres premiers.
//A l’aide de boucles « for » afficher les 5 premières tables de multiplication en allant jusque « x20 ».
//1x1 = 1 ; 2x1 = 2; ……
//2x1 = 2; 2x2 = 4; ……
//À l’aide d’une boucle « for » comptez de 0, à 20,0 en augmentant de 0,1, en utilisant des doubles, et afficher la valeur à chaque itération.
//Remarquez-vous quelque chose de particulier ?
//Bonus : Calculer la racine carré d’un nombre avec maximum 10 décimales (Math.Sqrt(x) ne peut être utilisée que pour vérifier la réponse),

Console.WriteLine("Hello, World!");
#region Facto
Console.WriteLine("Un nombre à facto ?");
string nb = Console.ReadLine()!; // Le ! permet de normaliser la variable unused. Pas nécessaire.
int nb2 = int.Parse(nb);
int[] nbprfacto = new int[nb2];
// Console.WriteLine(nbprfacto);
int temp = 1;
for (int i = 1; i <= (nb2-1); i += 1) // de 1 à nb2, pas de 1
{
    temp = temp * (i+1); // 1*2 = 2
    if (i == (nb2 - 1)) {
        Console.WriteLine($"Son factoriel est : {temp}"); //2
     }
}
#endregion

#region Fibo
// Fibonacci : tous les nb premiers jusque 25
Console.WriteLine("Voici gratos la suite Fibonacci jusque 25 : ");
int n1 = 0;
int n2 = 1;
int n3 = 0;
while (n3 < 25)
{
    n3 = n1 + n2;
    Console.WriteLine(n3);
    n1 = n2;
    n2 = n3;
}
;
#endregion

#region Multip
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"table de : {i}");
    for (int f = 0; f <= 10; f++) { 
        Console.WriteLine($"{i} x {f} = {i * f}"); 
    }

}

#endregion

#region Premiers
// Les questions qu'on se pose, exemple avec 5 :
// 5 % 2 == 0 ?
// 5 % 3 == 0 ?
// 5 % 4 == 0 ?

Console.WriteLine("Entrez un nombre : ");
int unb = int.Parse(Console.ReadLine()!);
int nb5 = 2; // nb5 parce que y'a déjà 1000 nb dans ce sheet de marde
int found = 0;

while (found < unb)
{
    bool estPremier = true;
    for (int i = 2; i <= nb5 - 1; i++)
    {
        if (nb5 % i == 0)
        {
            estPremier = false;
            break;
        }
    }

    if (estPremier) // = true
    {
        Console.WriteLine(n);
        found++;
    }
}

#endregion