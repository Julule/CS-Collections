Console.WriteLine("Hello, World!");
//  6) Le Bestiaire de Combat
//  Dans un jeu de rôle, le maître du jeu veut lister les monstres présents dans une zone.
//* Utilisez une liste pour stocker les noms des monstres.
//* Créez un menu en boucle qui propose :
//      1. Ajouter un monstre : L'utilisateur entre un nom (ex: "Gobelin"), qui est ajouté à la liste.
//      2. Supprimer un monstre : L'utilisateur entre le nom d'un monstre à retirer (si un monstre est vaincu).
//      3. Afficher le bestiaire : Montrer tous les monstres et le nombre total de créatures présentes.
//      4. Quitter.

List<string> bestiaire = ["maguiard", "gorgone", "harpie", "succube", "anémone"];
Console.WriteLine("Une fameuse ribambelle !");
Console.WriteLine(String.Join(",", bestiaire));

// AJOUTER UN MONSTRE
Console.WriteLine("Ajouter un montre ?");
string addmonstre = Console.ReadLine();
bestiaire.Add(addmonstre);
Console.WriteLine($"{addmonstre} entre dans la danse !");
Console.WriteLine(String.Join(", ", bestiaire));

// AJOUTER UN MONSTRE
Console.WriteLine("Retirer un montre (par son nom) ?");
string offmonstre = Console.ReadLine();
bestiaire.Remove(offmonstre);
Console.WriteLine($"{offmonstre} est vaincu !");
Console.WriteLine($"Il reste {bestiaire.Count} monstres :");
Console.WriteLine(String.Join(",", bestiaire));
