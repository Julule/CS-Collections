using System;

Console.WriteLine("Hello, World!");

// Raccourcis
// Ctrl K C                 Commenter un bloc sélectionné
// Ctrl K U                 Décommenter un bloc sélectionné
// Ctrl K S                 Entourer un bloc selectionné d'un protocole for, if, ...
// Ctrl D                   Dupliquer la ligne
// Ctrl
// Ctrl K D                 Ré-indenter
// Alt (bas) ou (haut)      Déplacer la ligne
// F5                       Démarrer le proj
// Ctrl C W                 ? Un truc pratique surement
// cw                       Dropdown : Console.WriteLine
//F2                        Remplacer partout (sur variable par ex)
// Ctrl ALT                 Multicurseur ?
//Ctrl Clic                 Voir fonction contenu



///////////////////
// Syntaxe générale
///////////////////

// Pas d'indentation obligée, mais propreté oblige, faut le faire
// indentation de python remplacée par {}
// le point virgule marque l'instruction suivante, l'équiv de retour-ligne en Python


/////////////////
// VARIABLES
/////////////////
///
// Typage nécessaire ! Une fois typée, la variable ne peut pas être typée autrement
var mavariable = 42; // typage automatique
int mavariable2 = 42; // typage manuel
int mavariable3; // quand elle reste vide pour l'instant. var dans ce cas est inadapté

// TYPES
// int = numérique codé squr 32 bits (équiv Int32)
// short = numérique petit codé sur 16 bits (RAREMENT) (équiv Int16)
// long = numérique long, codé sur 64 bits (équiv Int64)
long GrandNombre = 999999999999999999; // 18 chiffres limite

// double = nombre réel ou l'équiv. de float (qui existe aussi en C# mais moins précis 
double Double = 42.5;
//ou
var gnagna = (double)6;

// Chaîne de carac
string Prenom = "Julie"; //  double quote
char UnCaractere = 'J'; // simple Quote

// interpolation (concaténation) equiv du f(string) de python
string Chaine = $"Bonjour {Prenom} !"; // ça marche avec tout les types de variable

//multiligne
string Multi = @"

ceci est une chaîne 
de carcatères multilignes

";

// on peut combiner !
string MultiLine = @$" 

ceci est une chaîne 
de carcatères multilignes {Prenom}

";


int value = int.Parse("42"); // convenir un chaîne en entier

string entree = Console.ReadLine()!; // Le ! permet de normaliser la variable unused. Pas nécessaire.
string toCheck = entree[..10]; // pour récup les 10 premiers
// string controle = entree[2..]; // Les caractères à partir du 2ème, 0 inclus. 

// Booléen
bool VraiOuFaux = false; // en minuscule

int? Nullnull = null; // le ? est nécessaire à atttribuer Null à une variable.
var test2 = 42d; // typé double. marche aussi avec M, L, ..


/////////////////
// INPUT
/////////////////

Console.WriteLine("Ecrire dans la console"); // equiv print

string Entree = Console.ReadLine(); // équiv input, demande une entrée clavier

Console.Clear(); // Vider la console

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("En Cyan !");
Console.ResetColor(); // coul par défaut. Utile pour mettre en valeur les commentaires par exemple. 





// \b \n \c \t \n ... pour les chaînes de carac


/////////////////
// OPERATIONS
/////////////////

// "" + "" Concaténation
// + Addition
// - Soustraction
// * Multiplication
// / Divison
// % Modulo
Console.WriteLine(1 / 2); // resultat 0 car 1 et 2 sont des int, retourne un int
Console.WriteLine(1 / 2d); // resultat 0.5 car 2 est un double

int Milliard2 = 2000_000_000;
int Milliard1 = 1000_000_000;

Console.WriteLine(Milliard1 + Milliard2); // retourne un int negatif parce que résultat au delà de la limite

// LIMITES 
// Les calculs sont possibles de -2 milliards à +2 milliards.

Console.WriteLine(0.1 * 3); // retourne 0.300000000...4 parce qu'un double est d'office approx par le binaire

/////////////////
// BOUCLES
/////////////////

//  if (conditon) { }
//  elseif {}
//  elseif {}
//  else {}

//  switch(valeur) // pour comparer les égalités seulement
//  case
//  case
//  case
//  default


// opérateur ternaire
string categorie = value < 18 ? "Mineur" : "Majeur"; // voir exo


//Console.WriteLine("Entre un NB de 1 à 9");
//var nb = int.Parse(Console.ReadLine()!);


//while (nb < 1 || nb > 9)
//{
//    Console.WriteLine("Entrez un nombre de 1 à 9");
//    nb = int.Parse(Console.ReadLine()!);
//}

//Console.WriteLine($"Vous avez entré le nombre {nb}");


//// && c'est le 'et'
//// || c'est le 'ou'


// DO WHILE : répéter des instructions qui sont au moins executées une fois pour commencer. 
int nb;
do
{
    Console.WriteLine("Entrez un nombre de 1 à 9");
    nb = int.Parse(Console.ReadLine()!);
} while (nb < 1 || nb > 9);
Console.WriteLine($"Vous avez entré le nb {nb}");



