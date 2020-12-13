using System;
namespace etterem.Models.Records
{
    public class Konyvek
    {
        private string konyv_id;

        public string Konyv_id
        {
            get
            {
                return konyv_id;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("A könyvtári szám nem lehet nulla!");
                }
                if (value.Length != 4)
                {
                    throw new ArgumentOutOfRangeException("A köyvtári szám 4 karakter hosszú");
                }
                konyv_id = value;
            }
        }

        private string raktari_szam;

        public string Raktari_szam
        {
            get { return raktari_szam; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("A raktári szám nem lehet nulla!");
                }
                if (value.Length != 10)
                {
                    throw new ArgumentOutOfRangeException("A raktári szám 10 karakter hosszú");
                }
                raktari_szam = value;
            }
        }

        private string kiado;

        public string Kiado
        {
            get
            {
                return kiado;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("a kiadó nem lehet null");
                }
                kiado = value;
            }
        }

        private string cim;

        public string Cim
        {
            get
            {
                return cim;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("a cím nem lehet null");
                }
                cim = value;

            }
        }

        private Enum mufaj;

        public Enum Mufaj
        {
            get
            {
                return mufaj;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("a műfaj nem lehet null");
                }
                mufaj = value;

            }
        }

        private DateTime kiadas_eve;

        public DateTime Kiadas_eve
        {
            get
            {
                return kiadas_eve;
            }
            set
            {
                kiadas_eve = value;
            }
        }
    }
}
