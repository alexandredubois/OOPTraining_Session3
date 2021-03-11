using System;

namespace VehiculeManager
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vous pouvez ajouter ici votre code à exécuter

            Voiture twingo = new Voiture("Renault", "Twingo", "Rouge", 50);
            Vehicule twingo2 = new Voiture("Renault", "Twingo", "Rouge", 50);

            //N'enlevez pas la ligne suivante qui devra toujours être la dernière de votre programme :)
            Vehicule.QuiEstDansLesParages();
        }

    }
}
