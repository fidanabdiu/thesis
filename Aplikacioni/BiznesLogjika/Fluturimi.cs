using System;

namespace BiznesLogjika
{
    public class Fluturimi
    {
        private int aID;
        private Aeroplani aAeroplani;
        private Qyteti aQyteti;
        private DateTime aDataNisjes;
        private DateTime aOraNisjes;
        private PerdoruesiAeroportit aPerdoruesiAeroportit;
        private FluturimiAnuluar aFluturimiAnuluar;
        private decimal aCmimi;
        private decimal aCmimiKthyes;

        public Fluturimi()
        {
            aAeroplani = new Aeroplani();
            aQyteti = new Qyteti();
            aPerdoruesiAeroportit = new PerdoruesiAeroportit();
            aFluturimiAnuluar = FluturimiAnuluar.JO;
        }

        public int ID
        {
            get { return aID; }
            set { aID = value; }
        }

        public Aeroplani Aeroplani
        {
            get { return aAeroplani; }
            set { aAeroplani = value; }
        }

        public Qyteti Qyteti
        {
            get { return aQyteti; }
            set { aQyteti = value; }
        }

        public DateTime DataNisjes
        {
            get { return aDataNisjes; }
            set { aDataNisjes = value; }
        }

        public DateTime OraNisjes
        {
            get { return aOraNisjes; }
            set { aOraNisjes = value; }
        }

        public PerdoruesiAeroportit PerdoruesiAeroportit
        {
            get { return aPerdoruesiAeroportit; }
            set { aPerdoruesiAeroportit = value; }
        }

        public FluturimiAnuluar FluturimiAnuluar
        {
            get { return aFluturimiAnuluar; }
            set { aFluturimiAnuluar = value; }
        }

        public decimal Cmimi
        {
            get { return aCmimi; }
            set { aCmimi = value; }
        }

        public decimal CmimiKthyes
        {
            get { return aCmimiKthyes; }
            set { aCmimiKthyes = value; }
        }

        public override string ToString()
        {
            return ID.ToString();
        }
    }
}
