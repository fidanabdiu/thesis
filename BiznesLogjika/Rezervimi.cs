using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiznesLogjika
{
    public class Rezervimi
    {
        private int aID;
        private PerdoruesiAgjensionit aPerdoruesiAgjensionit;
        private Fluturimi aFluturimi;
        private Udhetari aUdhetari;
        private Ulesja aUlesja;
        private LlojiIRezervimit aLlojiRezervimit;
        private decimal aCmimi;

        public Rezervimi()
        {
            aPerdoruesiAgjensionit = new PerdoruesiAgjensionit();
            aFluturimi = new Fluturimi();
            aUdhetari = new Udhetari();
            aUlesja = new Ulesja();
        }

        public int ID
        {
            get { return aID; }
            set { aID = value; }
        }

        public PerdoruesiAgjensionit PerdoruesiAgjensionit
        {
            get { return aPerdoruesiAgjensionit; }
            set { aPerdoruesiAgjensionit = value; }
        }

        public Fluturimi Fluturimi
        {
            get { return aFluturimi; }
            set { aFluturimi = value; }
        }

        public Udhetari Udhetari
        {
            get { return aUdhetari; }
            set { aUdhetari = value; }
        }

        public Ulesja Ulesja
        {
            get { return aUlesja; }
            set { aUlesja = value; }
        }

        public LlojiIRezervimit LlojiRezervimit
        {
            get { return aLlojiRezervimit; }
            set { aLlojiRezervimit = value; }
        }

        public decimal Cmimi
        {
            get { return aCmimi; }
            set { aCmimi = value; }
        }

        public override string ToString()
        {
            return ID.ToString();
        }
    }
}
