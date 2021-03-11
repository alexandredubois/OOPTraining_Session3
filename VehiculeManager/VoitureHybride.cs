using System;

namespace VehiculeManager
{
    
    public class VoitureHybride : Voiture, IVehiculeThermique, IVehiculeElectrique
    {
        private int NiveauCarburant;
        private int NiveauBatterie;
        public void FaireLePlein()
        {
            NiveauCarburant = 100;
            Console.WriteLine("Le plein est fait");
        }

        public int GetNiveauBatterie()
        {
            return NiveauBatterie;
        }

        public int GetNiveauCarburant()
        {
            return NiveauCarburant
        }

        public void RechargerLaBatterie()
        {
            NiveauBatterie = 100;
            Console.WriteLine("La batterie est chargée");
        }

        public override void Accelerer()
        {
            if(NiveauBatterie > 0)
            {
                NiveauBatterie -= 5;
                NiveauCarburant -= 10;
            } else
            {
                if(NiveauCarburant >= 15)
                {
                    NiveauCarburant -= 15;
                } else
                {
                    NiveauCarburant = 0;
                    Vitesse = 0;
                }
            }
        }
    }
}
