using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pawboi
{
    class Agentie : ICloneable, IPrelucrare
    {
        private string denumireAgentie;
        private List<Imobil> listaImobile;

        public string DenumireAgentie { get => denumireAgentie; set => denumireAgentie = value; }
        internal List<Imobil> ListaImobile { get => listaImobile; set => listaImobile = value; }

        public Agentie()
        {
            denumireAgentie = "Imobiliare";
            listaImobile = new List<Imobil>();
        }
        public Agentie(string denumire, List<Imobil> lista)
        {
            denumireAgentie = denumire;
            listaImobile = lista;
        }

        public override string ToString()
        {
            string rezultat = "Agentia " + denumireAgentie + " are urmatoarele imobile: " + Environment.NewLine;
            foreach (Imobil i in listaImobile)
                rezultat += i.ToString() + Environment.NewLine;
            return rezultat;
        }
        public object Clone()
        {
            Agentie clona = (Agentie)this.MemberwiseClone();
            List<Imobil> listaClona = new List<Imobil>();
            foreach (Imobil i in listaImobile)
                listaClona.Add((Imobil)i.Clone());
            clona.listaImobile = listaClona;
            return clona;
        }

        //TODO: de adaugat else pentru toate cazurile
        //nu exista imobilul cu codul cautat
        public void ModificaNume(int cod, string numeNou)
        {
            if (listaImobile != null && cod >= 0 && cod < listaImobile.Count)
                listaImobile[cod].NumeImobil= numeNou;
        }

        public void ModificaLocatie(int cod, string locatieNou)
        {
            if (listaImobile != null && cod >= 0 && cod < listaImobile.Count)
                listaImobile[cod].LocatieImobil = locatieNou;
        }

        public void ModificaNrCamere(int cod, int nrCamereNou)
        {
            if (listaImobile != null && cod >= 0 && cod < listaImobile.Count)
                listaImobile[cod].NrCamereImobil = nrCamereNou;
        }

        public void ModificaPret(int cod, float pretNou)
        {
            if (listaImobile != null && cod >= 0 && cod < listaImobile.Count)
                listaImobile[cod].PretImobil = pretNou;
        }

        public Imobil this[int index]
        {
            get
            {
                if (listaImobile != null && index >= 0 && index < listaImobile.Count)
                    return listaImobile[index];
                else
                    return null;
            }
        }

        public static explicit operator float(Agentie a)
        {
            float mediePret = 0.0f;
            foreach (Imobil i in a.listaImobile)
                mediePret += i.PretImobil;
            return mediePret / a.listaImobile.Count;
        }
    }
}