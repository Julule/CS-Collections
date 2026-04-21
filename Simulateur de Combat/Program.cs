Console.WriteLine("Hello, World!");
//9) Le Simulateur de Combat au Tour par Tour (Complexe)
//Réalisez un moteur de combat simplifié entre une équipe de héros et un Boss.

//Structures de données à utiliser
//Une Queue<string> pour gérer l'ordre de passage (L'initiative).
//Une Dictionary<string, int> pour stocker les héros (Nom du héro et ses points de vie).
//Déroulement de l'application :
//Initialisation :

//L'utilisateur encode le nom des 3 héros (30 pdv).
//Le boss à 100 pdv.
//Remplir la file d'attente (Ordre : Héros 1, Héros 2, Héros 3, puis le Boss).
//La Boucle de Combat :

//Récuperer le personnage dont c'est le tour.
//Si c'est un héros : L'utilisateur choisit entre "Attaque" (entre 5 et 15 dégâts) ou "Soin" (rend entre 10 PV).
//Si c'est le Boss : Il attaque un héros au hasard et lui inflige 13 dégâts.
//Fin de tour, si le personnage est toujours vivant, il se réinscrit à la fin de la file.
//Fin de partie : Affichez qui a gagné et le nombre de tours qui ont eu lieu.