namespace Esercizi
{
    public class Studente
    {
        public string Nome;
        public string Cognome;
        public DateTime dataDiNascita;
        public ulong Matricola;
    }

    public class Universita
    {
        List<string> leSedi;
        Dictionary<string, Studente> lstStudenti;

        public Universita()
        {
            leSedi = new List<string>();
            lstStudenti = new Dictionary<string, Studente>();
        }

        public void AggiungiSede(string sSede)
        {
            leSedi.Add(sSede);
        }

        public bool AggiungiStudente(string sCodiceFiscale, string sNome, string sCognome, string sDataDiNascita, ulong uMatricola)
        {
            DateTime data;

            if (!DateTime.TryParse(sDataDiNascita, out data))
            {
                return false;
            }

            Studente nuovoStudente = new Studente();

            nuovoStudente.Nome = sNome;
            nuovoStudente.Cognome = sCognome;
            nuovoStudente.Matricola = uMatricola;
            nuovoStudente.dataDiNascita = data;

            if (!lstStudenti.ContainsKey(sCodiceFiscale))
            {
                lstStudenti.Add(sCodiceFiscale, nuovoStudente);
            }
            else
            {
                return false;
            }
            
            return true;
        }

        public void RimuoviSede(string sSede)
        {
            leSedi.Remove(sSede);
        }

        public bool RimuoviStudente(ulong uMatricola)
        {
            foreach ((string codiceFiscale, Studente studente) in lstStudenti)
            {
                if(studente.Matricola == uMatricola)
                {
                    lstStudenti.Remove(codiceFiscale);
                    return true;
                }
            }
            return false;
        }

        public bool CercaInSede(string sSede)
        {
            foreach(string sede in leSedi)
            {
                if (sede.ToLower() == sSede.ToLower())
                    return true;
                
            }
            return false;
        }

        public void CercaStudente(int iAnno, out List<Studente> lMatchingList)
        {
            lMatchingList = new List<Studente>();
            foreach((string codiceFiscale, Studente studente) in lstStudenti)
            {
                int Anno = studente.dataDiNascita.Year;
                if (iAnno == Anno)
                    lMatchingList.Add(studente);
            }
        }

        //funzione per listStudente

        /*
        public List<Studente> CercaStudente(int iAnno)
        {
            List<Studente> lMatchingList = new List<Studente>();
            lMatchingList = lstStudenti.FindAll(t => t.dataDiNascita.Year == iAnno);
            return lMatchingList;
        }*/
    }
}