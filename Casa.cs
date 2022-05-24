using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pawboi
{
    class Casa : Imobil
    {
        private bool arePiscina;
        private int marimeCurte;
        private string[] utilitati;

        public bool ArePiscina { get => arePiscina; set => arePiscina = value; }
        public int MarimeCurte { get => marimeCurte; set => marimeCurte = value; }
        public Casa() : base()
        {
            arePiscina = true;
            marimeCurte = 0;
            utilitati = new string[1] { "ceva" };
        }

        public Casa(int cod, string nume, float pret, int nrCamere, int marime, string locatie, bool piscina, int marimeC, string[] util) :
            base(cod, nume, pret, nrCamere, marime, locatie)
        {
            arePiscina = piscina;
            marimeCurte = marimeC;
            utilitati = util;
        }

        public string this[int index]
        {
            get
            {
                if (utilitati != null && index >= 0 && index < utilitati.Length)
                    return utilitati[index];
                else
                    return null;
            }
        }

        public override string ToString()
        {
            string rezultat = base.ToString() + " are piscina: " + arePiscina + " si marimea curtii este de " + marimeCurte + " si are urmatoarele utilitati: " + Environment.NewLine;
            if (utilitati != null)
            {
                for (int i = 0; i < utilitati.Length; i++)
                    rezultat += utilitati[i] + ", ";
            }
            else
                rezultat += " nu are utilitati!";
            
            return rezultat;
        }
    }
}