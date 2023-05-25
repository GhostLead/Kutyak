using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppKutyak
{
    internal class Kutyak
    {

        int id;
        string kutyanev;
        string fajtaMagyar;
        string fajtaAngol;

        public Kutyak(string CSVnev, string CSVfajta, string CSVkutyak)
        {
            var nevMezok = CSVnev.Split(";");
            var fajtaMezok = CSVfajta.Split(";");
            this.id = int.Parse(nevMezok[0]);
            this.kutyanev = nevMezok[1];
            this.fajtaMagyar = fajtaMezok[1];
            this.fajtaAngol = fajtaMezok[2];
        }

        public Kutyak(int id, string kutyanev)
        {
            this.id = id;
            this.kutyanev = kutyanev;
        }

        public int Id { get => id; set => id = value; }
        public string Kutyanev { get => kutyanev; set => kutyanev = value; }
    }
}
