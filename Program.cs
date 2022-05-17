using System;

namespace Esercizi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Universita universita = new Universita();
            Console.WriteLine(universita.AggiungiStudente("ciro", "piero", "nardi", "02/30/2020", 10000));
            Console.WriteLine(universita.AggiungiStudente("ciro", "piero", "nardi", "02/02/2020", 10000));
            Console.WriteLine(universita.AggiungiStudente("ciro", "piero", "nardi", "02/02/2020", 10000));

            /*
            Banca miaBanca = new Banca("pippo");
            miaBanca.aggiungiCliente("ciro", "grande", "grdcr12d5t490p", 4000);
            
            DateTime dataInizio = DateTime.Parse("10/11/2021");
            DateTime dataFine = DateTime.Parse("12/11/2021");

            DateTime dataInizio1 = DateTime.Parse("10/11/2021");
            DateTime dataFine1 = DateTime.Parse("10/12/2021");

            miaBanca.aggiungiPrestito("grdcr12d5t490p", 200, 10, dataInizio, dataFine);
            miaBanca.aggiungiPrestito("grdcr12d5t490p", 400, 10, dataInizio1, dataFine1);
            miaBanca.aggiungiPrestito("grdcr12d5t490p", 500, 10, dataInizio1, dataFine1);

            Console.WriteLine(miaBanca.AmmontarePrestitiPerCliente().ToArray()[0]);
            
            Prestito mioPrestito = miaBanca.listaPrestiti[0];
            Console.WriteLine(mioPrestito.giorniAllaScadenza());*/
        }
    }
}
