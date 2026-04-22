
#region Scoring
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Reflection;

Console.Clear();

//Réaliser une application qui permet d'encoder les scores pour du golf.
//- Dans un premier temps, l'application demande le nom (Unique) de tout les joueurs.
//- Ensuite, l'utilisateur doit renseigner le nombre d'étape du parcours.
//- Pour terminer, l'application demande le score de chaque joueurs pour chaque étapes !

//Une fois toutes les données encodées, calculer et afficher :
//- The winner (Personne avec le score total le plus faible).
//- Le joueur ayant fait le pire score lors d'une étape (le plus grand).
//- Afficher le classement des joueurs

int joueurs = 5;
Dictionary<int, string> listejoueurs  = new Dictionary<int, string>();

for (int i = 0; i < joueurs; i++)
{
    Console.WriteLine($"Quel est le nom du joueur {i+1} ?");
    string joueur = Console.ReadLine();
    listejoueurs.Add(i, joueur);
}

Console.WriteLine($"Combien d'étapes dans cette partie de golf ?");
int etapes = int.Parse(Console.ReadLine());
Dictionary<string, int> scores = [];
Dictionary<int, string> scoresreverse = [];

int[,] allscores = new int[listejoueurs.Count, etapes+1];

//Pour chaque etape
for (int j = 0; j < listejoueurs.Count; j++)
{ 
    string joueur = listejoueurs[j];
    //ajouter le joueur au tableau
    allscores[j, 0] = j;
    int score = 0;
    int scoresum = 0;
    for (int i = 0; i < etapes; i++)
    {
        Console.WriteLine($"Quel est le score de {listejoueurs[j]} à l'étape {i+1} ?");
        // ajouter le score au tableau
        
        score = int.Parse(Console.ReadLine());
        allscores[j, i + 1] = score;
        scoresum += score;
    }
    Console.WriteLine($"Score total de {joueur} : {scoresum}");
    scores.Add(joueur, scoresum);
    scoresreverse.Add(scoresum, joueur);
    Console.WriteLine(String.Join(" ", scores));
};

int winner = scores[listejoueurs[0]];
string winnerstr = listejoueurs[0];
for (int i = 0; i < scores.Count; i++)
{
    string joueur = listejoueurs[i];
    if (scores[joueur] < winner)
    {
        winnerstr = joueur;
    }
};
Console.WriteLine($"Le gagnant (avec le plus petit score) est : {winnerstr}");


// Trouver quel à été le pire coup de la partie, joueurs et étapes confondues
int pire = allscores[0, 1];
int etapepire = 0;
string joueurpire = "";

for (int i = 0; i < etapes; i++)
{
    for (int j = 1; j <= etapes; j++)
    {
        int pire2 = allscores[i, j];
        if (pire2 > pire)
        {
            pire = pire2;
            etapepire = j;
            joueurpire = listejoueurs[i];
        }

    }

}

Console.WriteLine($"Le pire score de la partie (le pus grand) est de {pire}, à l'étape {etapepire} par {joueurpire}");

// CLASSEMENT 
// utiliser le dictionnaire scores[joueur(string), scoresum(int)] / scores[string] = int pour générer une lmiste des scores finaux
List<int> classementscores = [];
foreach (KeyValuePair<string, int> joueur in scores)
{
    classementscores.Add(joueur.Value);
}

for (int i = 0; i >= classementscores.Count; i++) // Pour le dernier score de la liste, jsq premier
{
    for (int j = i; j >= classementscores.Count; j++)
    {
        Console.WriteLine(j);
        if (classementscores[i] > classementscores[j] || classementscores[i] == classementscores[j]) // Si son score est plus grand que le score du joueur idexé juste avant alors
        {
            //rien ne se passe
        }
        else if (classementscores[i] < classementscores[j]) // Si son score est plus petit que le score du joueur idexé juste avant alors
        {
            // Il s'insert avanT
            classementscores.Insert(j, classementscores[i]);
            classementscores.RemoveAt(i + 1); // il se retire de sa place
            Console.WriteLine(String.Join(",", classementscores));
        }
    }
    ;
};

for (int i = classementscores.Count-1; i >= 0 ; i--) // Pour le dernier score de la liste, jsq premier
{
    for (int j = i; j >= 0; j--)
    {
        Console.WriteLine(j);
        if (classementscores[i] > classementscores[j] || classementscores[i] == classementscores[j]) // Si son score est plus grand que le score du joueur idexé juste avant alors
        {
            //rien ne se passe
        }
        else if (classementscores[i] < classementscores[j]) // Si son score est plus petit que le score du joueur idexé juste avant alors
        {
            // Il s'insert avanT
            classementscores.Insert(j, classementscores[i]);
            classementscores.RemoveAt(i+1); // il se retire de sa place
            Console.WriteLine(String.Join(",", classementscores));
        }
    };
};



Console.WriteLine($"Le classement est, du gagant au perdant : ");
Console.WriteLine(String.Join(",", classementscores));
int n = 1;
foreach (int score in classementscores)
{
    Console.Write($"{n} : {scoresreverse[score]}   ");
    n++;
}
#endregion