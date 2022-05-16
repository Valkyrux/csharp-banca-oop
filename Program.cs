using System;

namespace Esercizi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banca miaBanca = new Banca("pippo");
            miaBanca.aggiungiCliente("ciro", "grande", "grdcr12d5t490p", 4000);
            DateTime dataInizio = DateTime.Parse("10/11/2021");
            DateTime dataFine = DateTime.Parse("12/11/2021");
            miaBanca.aggiungiPrestito("grdcr12d5t490p", 200, 10, dataInizio, dataFine);
            Console.WriteLine(miaBanca.listaClienti[0]);
            Prestito mioPrestito = miaBanca.listaPrestiti[0];
            Console.WriteLine(mioPrestito.giorniAllaScadenza());
        }
    }
}
