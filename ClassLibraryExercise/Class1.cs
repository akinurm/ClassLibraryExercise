using System;

namespace ClassLibraryExercise
{
    public class Class1
    {
        /*- Metodi, joka tarkistaa onko annettu päivämäärä tulevaisuudessa ja palauttaa true mikäli 
         * päivämäärä on tulevaisuudessa ja false mikäli päivämäärä on menneisyydessä
         
        - Metodi, joka kertoo opiskelun aloitusajan ja arvioidun opiskeluajan perusteella onko opiskelu myöhässä vai ei. 

         */

        public static bool OnkoAjoissa(DateTime aloitusaika, double arvioituOpiskeluaika)
        {
            double kulunutAika = (DateTime.Now.Date - aloitusaika.Date).Days * 24;
            if (kulunutAika < arvioituOpiskeluaika)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool OnkoTulevaisuudesta(DateTime paiva)
        {
         if (paiva>DateTime.Now)
            {
                return true;
            }
         else if (paiva < DateTime.Now)
            {
                return false;
            }
         else
            {
                return false;
            }
        }


    }
}
