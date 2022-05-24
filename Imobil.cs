using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pawboi
{
    public delegate void StringHandler(string a);
    public delegate void IntegerHandler(int x);
    class Imobil : IComparable, ICloneable
    {

        private int codImobil;
        private string numeImobil;
        private float pretImobil;
        private int nrCamereImobil;
        private int marimeImobil;
        private string locatieImobil;

        #region Getter-Setters
        public int CodImobil
        {
            get { return codImobil; }
            set { if (value > 0) codImobil = value; }
        }
        public string NumeImobil
        {
            get { return numeImobil; }
            set { if (value != null) numeImobil = value; }
        }
        public float PretImobil
        {
            get { return pretImobil; }
            set { if (value > 0) pretImobil = value; }
        }
        public int NrCamereImobil
        {
            get { return nrCamereImobil; }
            set { if (value > 0) nrCamereImobil = value; }
        }
        public int MarimeImobil
        {
            get { return marimeImobil; }
            set { if (value > 0) marimeImobil = value; }
        }
        public string LocatieImobil
        {
            get { return locatieImobil; }
            set { if (value != null) locatieImobil = value; }
        }
        #endregion
        #region Constructors
        public Imobil()
        {
            codImobil = 0;
            numeImobil = "Anonim";
            pretImobil = 0.0f;
            nrCamereImobil = 0;
            marimeImobil = 0;
            locatieImobil = "Bucuresti";
        }
        public Imobil(int cod, string nume, float pret, int nrCamere, int marime, string locatie)
        {
            codImobil = cod;
            numeImobil = nume;
            pretImobil = pret;
            nrCamereImobil = nrCamere;
            marimeImobil = marime;
            locatieImobil = locatie;
        }
        public Imobil(Imobil i)
        {
            this.codImobil = i.codImobil;
            this.numeImobil = i.numeImobil;
            this.pretImobil = i.pretImobil;
            this.nrCamereImobil = i.nrCamereImobil;
            this.marimeImobil = i.marimeImobil;
            this.locatieImobil = i.locatieImobil;
        }
        #endregion

        public event StringHandler Str;
        public event IntegerHandler Num;

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            Imobil i = (Imobil)obj;
            if (this.pretImobil < i.pretImobil)
                return -1;
            else if (this.pretImobil > i.pretImobil)
                return 1;
            else
                return string.Compare(this.numeImobil, i.numeImobil);
        }

        public override string ToString()
        {
            string rezultat = "Apartamentul " + numeImobil +
                              " cu codul " + codImobil +
                              " are " + nrCamereImobil +
                              " camere si marimea de " + marimeImobil +
                              " mp, se afla in " + locatieImobil +
                              " si are pretul de " + pretImobil;
            return rezultat;
        }

        public static Imobil operator +(Imobil i, float x)
        {
            i.pretImobil += x;
            return i;
        }

        public static Imobil operator +(float x, Imobil i)
        {
            return i + x;
        }

        public static Imobil operator -(Imobil i, float x)
        {
            i.pretImobil -= x;
            return i;
        }

        public static Imobil operator -(float x, Imobil i)
        {
            return i - x;
        }
    }
}
