# La classe Vehicule

1) Pouvez vous créer un objet de classe Vehicule dans le fichier Program.cs ? Essayez de deviner pourquoi.
2) Quel méthode est accessible même sans créer d'objet depuis la classe Véhicule ? Pourquoi ?
3) Ajouter un nouveau constructeur à 2 paramètres qui permet en plus de spécifier une couleur et une vitesse.
4) Créer une méthode Accelerer() qui incrémente la vitesse par pas de 10km/h
5) Créer une méthode Freiner() qui décrémentela vitesse par pas de 10km/h (celle-ci ne doit jamais devenir négative !)

# La classe Voiture

6) Créer la classe Voiture qui hérite de la classe Véhicule (cette classe ne doit pas contenir le mot clé "abstract")
7) Créer un objet de type voiture dans Program.cs
8) Quelles méthodes sont disponibles ?
9) Faites un clic-droit sur la classe Vehicule et exécutez la méthode QuiEstDansLesParages(). Que constatez-vous ?
10) Ajouter les propriétés "Marque" et "Modele" dans la classe Voiture 
11) Créer un constructeur attendant 4 paramètres qui va renseigner couleur, vitesse, marque et modèle de la voiture. (pensez au mot clé "base").
12) Créer une méthode void QuiSuisJe() qui permettra d'afficher dans la console quelque chose de la forme suivante : "Je suis une voiture (Renault/Mégane) de couleur rouge et je me déplace à 100km/h.". (le contenu devra varier avec les valeurs des propriétés)
13) Recréer un objet de type Voiture
14) Appeler de nouveau la méthode QuiEstDansLesParages(). Que constatez-vous ? Pourquoi le contenu n'est-il pas identique avec la précédente exécution ?

# La classe Camion

15) Créer une classe Camion qui hérite de véhicule (cette classe ne doit pas contenir le mot clé "abstract").
16) Que faudrait-il faire pour que le Camion possède également la propriété "Marque" (sans dupliquer de code) ? Modifier vos classes en conséquence.
17) Ajouter une nouvelle propriété "Tonnage" (de type entier).
18) Créer un constructeur attendant 4 paramètres qui va renseigner couleur, vitesse, marque et tonnage du camion. (pensez au mot clé "base").
19) Créer plusieurs objets, certains de type Voiture, d'autres de type Camion. Appeler la méthode QuiEstDansLesParages(), que constatez-vous ?
20) Créer une méthode void QuiSuisJe() qui permettra d'afficher dans la console quelque chose de la forme suivante : "Je suis un Camion Renault de 38 tonnes, de couleur rouge et je me déplace à 50km/h.". (le contenu devra varier avec les valeurs des propriétés)
21) A nouveau, créer plusieurs objets, certains de type Voiture, d'autres de type Camion. Appeler la méthode QuiEstDansLesParages(), que constatez-vous ?
22) Pourquoi le code de la méthode QuiEstDansLesParages(), dans la classe "Vehicule" est capable de manipuler des objets comme de type Camion ou Voiture ?

# On mélange tout

23) Dans la classe Voiture, ajouter une nouvelle propriété privée de type booléen, "CoffreOuvert"
24) Dans la classe Voiture, créer les méthodes publiques void OuvrirCoffre() et FermerCoffre qui influent sur cette propriété.
25) Ces méthodes sont-elles accessibles depuis un objet Camion ? Pourquoi ?
26) Ces méthodes  seraient-elles accessibles depuis un objet Véhicule (si on pouvait en créer un) ? Pourquoi ?
27) Dans les classes Voiture et Camion, redéfinissez la méthode Accélérer de la classe Véhicule (la Voiture accélère par pas de 10km/h jusqu'à 180km/h, le camion par pas de 5km/h jusqu'à 100km/h).
28) Serait-il possible de reproduire ces différents comportements sans avoir à redéfinir cette méthode dans les classes Voiture et Camion ? Si oui, faites-le.
