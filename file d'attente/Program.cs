using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, World!");
//7) File d'attente Multijoueur
//
//Simulez la file d'attente d'un serveur de jeu massivement multijoueur (MMO).
//- Créez une Queue<string> pour stocker les noms des joueurs en attente.
//- Initialiser la collection avec 5 joueurs à la file au démarrage (ex: "Joueur_A", "Joueur_B", etc.).
//-Créez un menu en boucle qui propose :
//      1.Prochain joueur: Afficher qui est le prochain joueur à entrer sans le retirer de la file (Méthode Peek).
//      2. Faites entrer : Retirer les deux premiers joueurs de la file (Méthode Dequeue) et affichez leur nom à l'écran.
//      3. Nouveau arrivant : Ajouter un nouveau joueur dans la file d'attente.
//      4. Nombre de joueur : Afficher le nombre de joueurs dans la file.

Console.WriteLine($"Bienvenue !");

Queue<string> file = [];
file.Enqueue("Link");
file.Enqueue("Esquie");
file.Enqueue("Ryuk");
file.Enqueue("Nana");
file.Enqueue("Susan");

Console.WriteLine($"Les joueureuses sont:{String.Join(",", file)}");
Console.WriteLine($"Le prochain joueur est {file.Peek()}");

Console.WriteLine($"{file.Dequeue()}");
Console.WriteLine($"{file.Dequeue()}");
Console.WriteLine($"Les joueureuses sont maintenant:{String.Join(",", file)}");

file.Enqueue("Archie");
Console.WriteLine($"Avec un nouveau joeur, on en est à :{String.Join(",", file)}, ce qui donne {file.Count}");



