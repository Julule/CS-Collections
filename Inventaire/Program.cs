Console.WriteLine("Hello, World!");
//5) L'Inventaire de l'Aventurier
//Un héros commence son aventure avec un sac à dos limité à 5 emplacements (type: string).
//- Permettre à l'utilisateur de remplir chaque emplacement en encodant le nom d'un objet (ex: Épée, Potion, Bouclier).
//- Une fois le sac plein, l'application doit :
//      1. Afficher la liste complète des objets avec leur numéro d'index (de 0 à 4).
//      2. Demander à l'utilisateur s'il veut remplacer un objet. Si oui, l'utilisateur encode l'index de l'objet à remplacer et le nom du nouvel objet.
//      3. Afficher l'inventaire mis à jour.


string unit = "5";
int unitcount = int.Parse(unit);
Dictionary<int, string> inventaire = [];
List<string> inventaire2 = [];

for (int u = 0; u < unitcount; u++)
{
    Console.WriteLine($"Quel objet se trouve dans l'emplacement {u + 1} ?");
    string objet = Console.ReadLine();
    inventaire.Add(u+1, objet);
    inventaire2.Add(objet);
}

// AFFICHER L'INVENTAIRE
Console.WriteLine($"Très bel inventaire! : ");
foreach (string objet in inventaire2)
{
    int index = inventaire2.IndexOf(objet);
    Console.WriteLine($"{index+1}- {objet}");
}


Console.WriteLine($"Pour remplacer un objet, encoder son emplacement");
int indexrempla = int.Parse(Console.ReadLine());
Console.WriteLine($"Quel est l'objet ?");
string objetrempla = Console.ReadLine();

// AJOUTER A L'INVENTAIRE
inventaire2.Insert(indexrempla, objetrempla);

// AFFICHER L'INVENTAIRE DE NOUVEAU
Console.WriteLine($"Un nouvel inventaire! : ");
foreach (string objet in inventaire2)
{
    int index = inventaire2.IndexOf(objet);
    Console.WriteLine($"{index + 1}- {objet}");
}

