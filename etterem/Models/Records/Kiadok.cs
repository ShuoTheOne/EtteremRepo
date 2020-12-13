using System;
namespace etterem.Models.Records
{
    public class Kiadok
    {
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
                    throw new ArgumentNullException("A kiadó id nem lehet nulla!");
                }
               id = value;
            }
        }

        private string nev;

        public string Nev
        {
            get { return nev; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("A név nem lehet nulla!");
                }
                nev = value;
            }
        }
    }
}
