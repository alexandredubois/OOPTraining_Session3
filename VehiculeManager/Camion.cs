using System;

namespace VehiculeManager
{
    public class Camion : Vehicule, IVehiculeThermique
    {
        public int Tonnage { get; set; }

        private int NiveauCarburant;

        public Camion(string couleur, string marque, int vitesse, int tonnage)
            : base(vitesse, couleur, marque)
        {
            Tonnage = tonnage;
            NiveauCarburant = 100;
        }
        public override void Accelerer()
        {
            if (Vitesse <= 95)
            {
                Vitesse += 5;
                NiveauCarburant -= 15;
            }
        }

        public override void QuiSuisJe()
        {
            Console.WriteLine("Je suis un Camion {0} de {1} tonnes, de couleur {2} et je me déplace à {3}km / h.",
                Marque,
                Tonnage,
                Couleur,
                Vitesse);
        }

        public override string GetImmatriculation()
        {
            return "EF-334-TZ";
        }

        public void FaireLePlein()
        {
            NiveauCarburant = 100;
            Console.WriteLine("Le plein est fait");
        }

        public int GetNiveauCarburant()
        {
            return NiveauCarburant;
        }
    }
}
