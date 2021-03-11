using System;
using System.Collections.Generic;
using System.Globalization;

namespace VehiculeManager
{
    public abstract class Vehicule
    {
        public string Couleur { get; set; }
        public int Vitesse { get; set; }
        public string Marque { get; set; }

        private static List<Vehicule> Liste;

        public Vehicule()
        {
            Couleur = "inconnue";
            Vitesse = 0;
            AjouterDansListe();
        }

        public Vehicule(int vitesse, string couleur, string marque)
        {
            Couleur = couleur;
            Vitesse = vitesse;
            Marque = marque;
            AjouterDansListe();
        }

        public virtual void Accelerer()
        {
            Vitesse += 10;
        }


        public void Freiner()
        {
            //Vitesse = Vitesse >= 10 ? Vitesse - 10 : 0;

            if(Vitesse >= 10)
            {
                Vitesse -= 10;
            } else
            {
                Vitesse = 0;
            }
        }

        public abstract string GetImmatriculation();

        public virtual void QuiSuisJe()
        {
            Console.WriteLine(string.Format(CultureInfo.InvariantCulture, "Je suis un véhicule non-identifié de couleur {0} qui se déplace à {1} km/h", Couleur, Vitesse));
        }

        public static void QuiEstDansLesParages()
        {
            Console.WriteLine("---------------------------------");
            if (Liste != null && Liste.Count > 0)
            {
                Console.WriteLine("Il y a du monde ici !");
                foreach (Vehicule item in Liste)
                {
                    item.QuiSuisJe();
                }
            }
            else
            {
                Console.WriteLine("Personne dans les parages...");
            }
            Console.WriteLine("---------------------------------");
        }

        private void AjouterDansListe()
        {
            if (Liste == null)
                Liste = new List<Vehicule>();

            Liste.Add(this);
        }
    }
}
