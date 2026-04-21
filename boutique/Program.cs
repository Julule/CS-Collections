Console.WriteLine("Hello, World!");
//8) La Boutique d'équipement
//Dans un jeu, le joueur intéragi avec le marchant de la boutique pour acheter de l'equipement.
//- L'application doit permettre de gérer le stock des équipements (quantité et prix).
//- Le joueur à 250 piece pour acheter de l'équipements.

//Fonctionnement de l'application :
//- Créer un Dictionary<string, int> pour représenter le stock de la boutique.
//- Initialisez le dictionnaire avec de l'équipement (ex: "Arc": 5, "Hache": 2, "Dague": 10, ...).
//- Créez un menu en boucle qui propose :
//      1.Voir le catalogue : Afficher l'équipement en stock avec son prix
//      2. Acheter un équipement : Le joueur dépense son or pour faire un achat.
//      3. Voler un équipement : Le joueur peut tenter de volé un équipement (10% de succes, en cas d'echec -> Game Over).
//      4. Quitter la boutique : Fin de l'intéraction avec le marchant. Afficher la liste des achats de joueur.

//Condition à respecter :
//- Si l'équipement est en stock et que le joueur a l'or necessaire, l'achat est réussi.
//- Si le joueur n'a pas assez d'or pour faire l'achat, le marchant se fou de lui !
//- Si l'équipement n'est pas en stock, le marchant indique que c'est en rupture de stock.
//- Si le joueur arrive à 0 or, le marchant force le joueur à partir en ricanant.

