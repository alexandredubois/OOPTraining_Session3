using System;

namespace VehiculeManager
{
    public class Voiture : Vehicule
    {

        public string Modele { get; set; }

        private bool coffreOuvert;

        public Voiture()
        {

        }
        public Voiture(string marque, string modele, string couleur, int vitesse)
            : base(vitesse, couleur, marque)
        {
            Modele = modele;
        }

        public void OuvrirCoffre()
        {
            coffreOuvert = true;
        }

        public void FermerCoffre()
        {
            coffreOuvert = false;
        }

        public override void Accelerer()
        {
            if(Vitesse <= 170)
            {
                base.Accelerer();
            }
        }

        public override void QuiSuisJe()
        {
            Console.WriteLine("Je suis une voiture({0} / {1}) de couleur {2} et je me déplace à {3}km / h.",
                Marque,
                Modele,
                Couleur,
                Vitesse);
        }

        public override string GetImmatriculation()
        {
            return "EF-336-TZ";
        }

    }
}
