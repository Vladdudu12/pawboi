using System;
using System.Collections.Generic;
using System.Text;

namespace pawboi
{
    interface IPrelucrare
    {
        void ModificaNume(int cod, string numeNou);
        void ModificaLocatie(int cod, string locatieNou);
        void ModificaNrCamere(int cod, int nrCamereNou);
        void ModificaPret(int cod, float pretNou);
    }
}
