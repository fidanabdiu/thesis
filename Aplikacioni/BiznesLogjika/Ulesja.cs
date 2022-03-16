namespace BiznesLogjika
{
    public class Ulesja
    {
        private int aID;
        private int aNumri;
        private Aeroplani aAeroplani;
        private UlesjaEZene aUlesjaEZene;

        public Ulesja()
        {
            aAeroplani = new Aeroplani();
            aUlesjaEZene = UlesjaEZene.JO;
        }

        public int ID
        {
            get { return aID; }
            set { aID = value; }
        }

        public int Numri
        {
            get { return aNumri; }
            set { aNumri = value; }
        }

        public Aeroplani Aeroplani
        {
            get { return aAeroplani; }
            set { aAeroplani = value; }
        }

        public UlesjaEZene UlesjaEZene
        {
            get { return aUlesjaEZene; }
            set { aUlesjaEZene = value; }
        }

        public override string ToString()
        {
            return aNumri.ToString();
        }
    }
}
