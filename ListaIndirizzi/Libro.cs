using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaIndirizzi
{
    internal class Indirizzo
    {
        private string nome;
        private string cognome;
        private string via;
        private string citta;
        private string provincia;
        private int codice_postale;


        public Indirizzo(string nome, string cognome, string via, string citta, string provincia, int codice_postale)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.via = via;
            this.citta = citta;
            this.provincia = provincia;
            this.codice_postale = codice_postale;
        }





        public override string ToString()
        {
            string riga = "------INDIRIZZO---------\n";
            riga += "Nome:" + this.nome + "\n";
            riga += "Cognome:" + this.cognome + "\n";
            riga += "Via:" + this.via + "\n";
            riga += "Città:" + this.citta + "\n";
            riga += "Provincia:" + this.provincia + "\n";
            riga += "Codice Postale:" + this.codice_postale + "\n";
            return riga;


        }
    }
}
