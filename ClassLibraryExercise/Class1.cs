using System;

namespace ClassLibraryExercise
{
    public class Class1
    {
        /*Metodi, joka tarkistaa onko annettu päivämäärä tulevaisuudessa ja palauttaa true mikäli 
         * päivämäärä on tulevaisuudessa ja false mikäli päivämäärä on menneisyydessä*/

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
