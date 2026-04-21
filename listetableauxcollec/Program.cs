
using System;
using System.Collections;
using System.Globalization;

int[] notes = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
string[] prenomsL = new string[3] { "Léa", "Léo", "Léu" };
string[] prenomsA = new string[3];
prenomsA[0] = "Aude"; // il remplace !

for (int i = 0; i < prenomsA.Length; i++)
{
    Console.WriteLine(String.Join(" ", prenomsA));
}

int[,] tableau = new int[5, 2]; // équiv de :
int[] tableau2 = [5, 2];
tableau[3, 1] = (42);
int[] tab3 = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

// Console.WriteLine("Valeur du tab 3: {}, {1}, {2}", tab3[1], tab3[2], tab3[3]);
Console.WriteLine("Valeur du tab 3:" + tab3[1], tab3[2], tab3[3]);
Console.WriteLine("Tout le tab3 :");
Console.WriteLine(string.Join(",", tab3));
Console.WriteLine(tab3.Length);

ArrayList list = new ArrayList(); // type dynamique, taille dynamique, jamais utilisé
list.Add("Bonjour");
list.Add(42);
list.Add(null);
Console.WriteLine(list.Count);
var valeur = (string)list[0]; // Comme tout est dynam, je suis obligé de demander le bon type 
Console.WriteLine(valeur);

List<int> list2 = new List<int> { 1, 2, 3 }; // ou alors :
List<int> list3 = [1, 2, 3];
list2[2] = 5;
list2.Add(42);
list2.AddRange(25, 26, 27);
int duck = list2[1];

list2.RemoveAt(2);
list2.Remove(2);
// list2.RemoveAll(elem => elem.Contains("i")); // si elem est une string
list2.RemoveAll(elem => elem.Equals(2));

Hashtable hash = new Hashtable();
hash.Add(42, "Bonsoir"); // on peut ajouter n 'imp 
hash.Add("Bonjour", DateTime.Now); // on peut ajouter n 'imp
Console.WriteLine(hash["Bonjour"]);

Queue file = new Queue(); // FIFO, on agit sur le PREMIER ELEMENT
file.Enqueue(42); // ajoute à la fin
file.Enqueue("Bonjour");
file.Dequeue(); // retire du début
Console.WriteLine(file.Peek()); // Regarde le premier de la liste

Stack pile = new Stack(); // LIFO, on agit sur le DERNIER ELEMENT
pile.Push(42);
pile.Push("Salut");
Console.WriteLine(pile.Peek());



foreach (int a in list2)
{
    Console.WriteLine(a);
};

Dictionary<string, string> dico = new Dictionary<string, string>();
dico.Add("Panda", "Jungle");
dico.Add("Elephant", "Savane");
dico.Add("Renard", "Forêt");

foreach (KeyValuePair<string, string> item in dico)
{
    Console.WriteLine(item.Key);
    Console.WriteLine(item.Value);
}

Queue<int> file2 = new Queue<int>();

Stack<int> pile2 = new Stack<int>();
pile2.Push(0);
pile2.Push(1);
pile2.Push(2);

Console.WriteLine(pile2.Peek()); // 
Console.WriteLine(pile2.Pop()); // retire dernier et récupère


// Dico d'étudiants
Console.Clear();

bool addstudents = false;
Dictionary<string, double> listetu = new ();

do
{
    Console.WriteLine("Nom de l'étudiant");
    string student = Console.ReadLine(); // soulignement vert (nulll safe)
                                         // string student = Console.ReadLine() ?? throw new Exception ("nom vide !"); // Plus safe, pour le cas ou student est null

    Console.WriteLine("Moyenne de l'étudiant");
    double result = double.Parse(Console.ReadLine());

    listetu.Add(student, result);

    Console.WriteLine("Ajouter un aure étudiant (y/N)");
    addstudents = Console.ReadLine() == "y"; // Teste : si "y" : reste true
    // addstudents = Console.ReadLine().Equals("y", StringComparison.OrdinalIgnoreCase);

} while (addstudents);

foreach(var elem in listetu)
{
    string student = elem.Key;
    double result = elem.Value;

    Console.WriteLine($" - {student} : {result}");
}






