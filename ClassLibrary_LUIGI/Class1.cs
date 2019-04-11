using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_LUIGI
{
    public class Class
    {

        //calcolo la frequenza cardiaca massima
        public static string FrequenzaCMax(string eta)
        {
            string FCM = "";

            try
            {
                double numero = Convert.ToDouble(eta);

                if (numero <= 0)
                {
                    FCM = "Errore";
                }
                else
                {
                    double FCMax = 220 - numero;

                    FCM = Convert.ToString(FCMax);
                }
            }
            catch (Exception)
            {
                FCM = "Errore";
            }

            return FCM;
        }

        //calcolo il numero dei battiti minimi
        public static string NBattitiMin(string FCMax)
        {
            string BM = "";

            try
            {
                double FCM = Convert.ToDouble(FCMax);

                if (FCM <= 0)
                {
                    BM = "Errore";
                }
                else
                {
                    double BMin = FCM * 0.7;

                    BM = Convert.ToString(BMin);
                }
            }
            catch (Exception)
            {
                BM = "Errore";
            }

            return BM;
        }

        //calcolo il numero dei battiti massimi
        public static string NBattitiMax(string FCMax)
        {
            string BM = "";

            try
            {
                double FCM = Convert.ToDouble(FCMax);

                if (FCM <= 0)
                {
                    BM = "Errore";
                }
                else
                {
                    double BMax = FCM * 0.9;

                    BM = Convert.ToString(BMax);
                }
            }
            catch (Exception)
            {
                BM = "Errore";
            }

            return BM;
        }


    }
}
