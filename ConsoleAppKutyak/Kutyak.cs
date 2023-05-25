using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKutyak
{
    internal class Kutyak
    {

        int nevId;
        string kutyanev;

        int fajtaId;
        string fajtaMagyar;
        string fajtaAngol;

        int kutyakId;
        int kutyakNevId;
        int kutyakFajtaId;
        int eletkor;
        string utsoEllenorzes;

        public Kutyak(string CSVnev, string CSVfajta, string CSVkutyak)
        {
            var nevMezok = CSVnev.Split(";");
            var fajtaMezok = CSVfajta.Split(";");
            var kutyakMezok = CSVkutyak.Split(";");
            
            // id-k beolvasása
            this.kutyakId = int.Parse(kutyakMezok[0]);
            this.kutyakFajtaId = int.Parse(kutyakMezok[1]);
            this.kutyakNevId = int.Parse(kutyakMezok[2]);

            // adatok beolvasasa
            this.kutyanev = nevMezok[1];
            this.fajtaMagyar = fajtaMezok[1];
            this.fajtaAngol = fajtaMezok[2];
            this.eletkor = int.Parse(kutyakMezok[3]);
            this.utsoEllenorzes = kutyakMezok[4];
        }

        public Kutyak(int nevId, string kutyanev, int fajtaId, string fajtaMagyar, string fajtaAngol, int kutyakId, int kutyakNevId, int kutyakFajtaId, int eletkor, string utsoEllenorzes)
        {
            this.nevId = nevId;
            this.kutyanev = kutyanev;
            this.fajtaId = fajtaId;
            this.fajtaMagyar = fajtaMagyar;
            this.fajtaAngol = fajtaAngol;
            this.kutyakId = kutyakId;
            this.kutyakNevId = kutyakNevId;
            this.kutyakFajtaId = kutyakFajtaId;
            this.eletkor = eletkor;
            this.utsoEllenorzes = utsoEllenorzes;
        }

        public int NevId { get => nevId; set => nevId = value; }
        public string Kutyanev { get => kutyanev; set => kutyanev = value; }
        public int FajtaId { get => fajtaId; set => fajtaId = value; }
        public string FajtaMagyar { get => fajtaMagyar; set => fajtaMagyar = value; }
        public string FajtaAngol { get => fajtaAngol; set => fajtaAngol = value; }
        public int KutyakId { get => kutyakId; set => kutyakId = value; }
        public int KutyakNevId { get => kutyakNevId; set => kutyakNevId = value; }
        public int KutyakFajtaId { get => kutyakFajtaId; set => kutyakFajtaId = value; }
        public int Eletkor { get => eletkor; set => eletkor = value; }
        public string UtsoEllenorzes { get => utsoEllenorzes; set => utsoEllenorzes = value; }
    }
}
