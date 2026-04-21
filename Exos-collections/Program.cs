// Une appli qui encode des nombre pour :
// - Moyenne
// - Somme
// - Valeur max
// - Valeur min
// disons 3 nb, 5, 5, 5 = 25

// Solution avec :
// - Un tableau
// - une collection générique 

using System.Text;

Console.WriteLine("Combien de nb avez vous ?");
int nbnb = int.Parse(Console.ReadLine());
List<int> lmoy = [];
int somme = 0;
int max = 0;
int min = 0;

for (int i = 1; i <= nbnb; i++)
{
    Console.WriteLine($"Nb {i} ?");
    int usernb = int.Parse(Console.ReadLine());
    lmoy.Add(usernb);
    somme = lmoy[i - 1] + somme;
    if (i == 1)
    {
        min = usernb;
        max = usernb;
    }
    else if (usernb > max)
    {
        max = usernb;
    }
    else if (usernb < min)
    {
        min = usernb;
    }
}

Console.WriteLine($"La somme est {somme}, \nLa moyenne est {somme / nbnb}, \nLe max est {max}, \nLe min est {min}");
Console.ReadLine();

////////////////////////////////////////////////////////////////////////////////////////////////

Console.Clear();
// Appli pour ajouter nouvelles tâches
// visualiser les tâches 
// effacer des tâches

Dictionary<string, string> todo = [];


Console.WriteLine($"Combiend de tâches à mettre dans la todo?");
int nbtodo = int.Parse(Console.ReadLine());
for (int i = 1; i <= nbtodo; i++)
{
    Console.WriteLine($"Tache {i} ?");
    string tache = Console.ReadLine();
    todo.Add("TX-" + i, tache);
}

Console.WriteLine($"Taper un nombre pour voir une tâche (Format TX-...)");
string userclef = Console.ReadLine();
todo.TryGetValue(userclef, out string tachespe);

Console.WriteLine($"La tâche est : \"{tachespe}\" ");

Console.WriteLine($"Vider la liste ? y/N");
//Console.WriteLine($"{todo.Values}");
string uanswer = Console.ReadLine();
do
{
    Console.WriteLine($"Vider la liste ? y/N");
    uanswer = Console.ReadLine();
} while (uanswer == "N");

    todo.Clear();












