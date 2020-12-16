using System;
namespace konyvtar.Models.Records
{
    public class Konyvek
    {
        public Konyvek()
        {

        }

        public Konyvek(string id, string raktari_szam, string kiado_id, string cim, Mufaj Mufaj, string kiadas_eve)
        {
            this.Id = id;
            this.Raktari_szam = raktari_szam;
            this.Kiado_id = kiado_id;
            this.Cim = cim;
            this.Mufaj = mufaj;
            this.Kiadas_eve = kiadas_eve;
        }

        private string id;

        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("A könyvtári szám nem lehet nulla!");
                }
                id = value;
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

        private string kiado_id;

        public string Kiado_id
        {
            get
            {
                return kiado_id;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("a kiadó nem lehet null");
                }
                if (value.Length < 2)
                {
                    throw new ArgumentNullException("a kiadó nem lehet 2nél kisebb");
                }
                kiado_id = value;
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
                if (value.Length < 2)
                {
                    throw new ArgumentNullException("a cím nem lehet 2nél kisebb");
                }
                cim = value;

            }
        }

        private Mufaj mufaj;

        public Mufaj Mufaj
        {
            get
            {
                return mufaj;
            }
            set
            {
                mufaj = value;

            }
        }

        private string kiadas_eve;
        public string Kiadas_eve
        {
            get
            {
                return kiadas_eve;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("a dátum nem lehet null");
                }
                if (value.Length > 2021 || value.Length < -20000)
                {
                    throw new ArgumentNullException("ez a könyv még nem jelenhetett meg!");
                }
                kiadas_eve = value;
            }
        }
    }
}
