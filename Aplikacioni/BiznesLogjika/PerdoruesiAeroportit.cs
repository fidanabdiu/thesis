using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiznesLogjika
{
    public class PerdoruesiAeroportit : Personi
    {
        private string aPseudonimi;
        private string aFjalekalimi;
        private Privilegji aPrivilegji;

        public PerdoruesiAeroportit()
        {
            aFjalekalimi = aPseudonimi;
        }

        public string Pseudonimi
        {
            get { return aPseudonimi; }
            set { aPseudonimi = value; }
        }

        public string Fjalekalimi
        {
            get { return aFjalekalimi; }
            set { aFjalekalimi = value; }
        }

        public Privilegji Privilegji
        {
            get { return aPrivilegji; }
            set { aPrivilegji = value; }
        }

        public override string ToString()
        {
            return Emri + " " + Mbiemri;
        }
    }
}
