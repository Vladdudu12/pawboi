using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pawboi
{
    class Apartament : Imobil
    {
        private bool areCentrala;
        private int marimeBalcon;

        public bool AreCentrala { get => areCentrala; set => areCentrala = value; }
        public int MarimeBalcon { get => marimeBalcon; set => marimeBalcon = value; }

        public Apartament() : base()
        {
            areCentrala = true;
            marimeBalcon = 0;
        }

        public Apartament(int cod, string nume, float pret, int nrCamere, int marime, string locatie, bool centrala, int marimeB) :
            base(cod, nume, pret, nrCamere, marime, locatie)
        {
            areCentrala = centrala;
            marimeBalcon = marimeB;
        }

        public override string ToString()
        {
            string rezultat = base.ToString() +
                              " are centrala " + areCentrala +
                              " si marimea Balconului este de " + marimeBalcon +
                              " mp" + Environment.NewLine;
            return rezultat;
        }
    }
}