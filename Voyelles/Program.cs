
#region Voyelles
Console.Clear();

Console.WriteLine($"Dîtes moi quelque chose :)");
string uwords = Console.ReadLine();
int longueur = uwords.Length;

// Déclarer une collection char de voyelles, pour pouvoir les comparer en itérant dans la string
List<char> voylist = ['a', 'e', 'i', 'o', 'u', 'y'];

//préparer une liste de char pour les voyelles de l'utilisateur
List<char> uvoylist = [];

// Itérer chaque voyelle en tant que char dans uvoylist

foreach (char letter in uwords)
{
    for (int voy = 0; voy < voylist.Count; voy++)
    {
        if (letter == voylist[voy])
        {
            Console.WriteLine(letter);
            Console.WriteLine(voylist[voy]);
            uvoylist.Add(letter);
        }
    }
};

longueur = uvoylist.Count;
Console.WriteLine($"Le nombre de voyelles est : {longueur}");


#endregion