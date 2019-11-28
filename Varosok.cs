using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatvanyossagokApplication
{
    class Varosok
    {
        int id;
        string nev;
        int lakossag;

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public int Lakossag { get => lakossag; set => lakossag = value; }

        public Varosok(int id, string nev, int lakossag)
        {
            Id = id;
            Nev = nev;
            Lakossag = lakossag;
        }
        public override string ToString()
        {
            return nev;
        }
    }
}
