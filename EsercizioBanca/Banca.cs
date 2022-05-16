using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizi
{
    internal class Banca
    {
        private string nome;
        public List<Cliente> listaClienti;
        public List<Prestito> listaPrestiti;

        public Banca(string nome)
        {
            this.nome = nome;
            this.listaClienti = new List<Cliente>();
            this.listaPrestiti = new List<Prestito>();
        }

        public void aggiungiCliente(string nome, string cognome, string codiceFiscale, double stipendio)
        {
            Cliente nuovoCliente = new Cliente(nome, cognome, codiceFiscale, stipendio);
            this.listaClienti.Add(nuovoCliente);
        }

        public bool modificaCliente(string codiceFiscale, double stipendio)
        {
            Cliente? clienteDaModificare = listaClienti.Find(t => t.codiceFiscale == codiceFiscale);
            if(clienteDaModificare != null)
            {
                clienteDaModificare.stipendio = stipendio;
                return true;
            }
            return false;
        }

        public bool eliminaCliente(string codiceFiscale)
        {
            foreach (Cliente cliente in this.listaClienti)
            {
                if (cliente.codiceFiscale == codiceFiscale)
                {
                    listaClienti.Remove(cliente);
                    return true;
                }
            }
            return false;
        }

        public bool cercaCliente(string codiceFiscale)
        {
            foreach (Cliente cliente in this.listaClienti)
            {
                if (cliente.codiceFiscale == codiceFiscale)
                {
                    return true;
                }
            }
            return false;
        }

        public bool aggiungiPrestito(string codiceFiscale, double cifra, double valoreRata, DateTime inizio, DateTime fine)
        {
            if(listaClienti.Find(x => x.codiceFiscale == codiceFiscale) != null)
            {
                Prestito nuovoPrestito = new Prestito(codiceFiscale, cifra, valoreRata, inizio, fine);
                this.listaPrestiti.Add(nuovoPrestito);
                return true;
            }
            return false;
        }

        public double ammontarePrestiti(string codiceFiscale)
        {
            double totale = 0;
            foreach(Prestito prestito in this.listaPrestiti)
            {
                if(prestito.codiceFiscaleIntestatario == codiceFiscale)
                {
                    totale += prestito.ammontare;
                }
            }
            return totale;
        }
    }

    public class Cliente
    {
        private string nome { get; set; }
        private string cognome { get; set; }
        public string codiceFiscale { get; set; }
        public double stipendio { get; set; }

        public Cliente(string nome, string cognome, string codiceFiscale, double stipendio)
        {
            this.nome=nome;
            this.cognome=cognome;
            this.codiceFiscale=codiceFiscale;
            this.stipendio=stipendio;
        }

        public override string ToString()
        {
            return string.Format("NOME: {0},\nCOGNOME: {1},\nCODICEFISCALE: {2},\nSTIPENDIO: {3}", this.nome, this.cognome, this.codiceFiscale, this.stipendio);
        }
    }

    public class Prestito
    {
        public string codiceFiscaleIntestatario { get; set; }
        public double ammontare { get; set; }
        private double rata { get; set; }
        private DateTime dataInizio { get; set; }
        private DateTime dataFine { get; set; }

        public Prestito(string codiceFiscale, double cifra, double valoreRata, DateTime inizio, DateTime fine)
        {
            this.codiceFiscaleIntestatario = codiceFiscale;
            this.ammontare = cifra;
            this.rata = valoreRata;
            this.dataInizio = inizio;
            this.dataFine = fine;
        }

        public int giorniAllaScadenza()
        {
            TimeSpan differenza = dataFine - dataInizio;
            return (int)differenza.TotalDays;
        }
    }
}
