namespace BiznesLogjika
{
    public class Aeroplani
    {
        private int aID;
        private LinjaAjrore aLinjaAjrore;
        private TipiAeroplanit aTipiAeroplanit;
        private MarkaAeroplanit aMarkaAeroplanit;
        private int aNumriUleseve;

        public Aeroplani()
        {
            aLinjaAjrore = new LinjaAjrore();
            aTipiAeroplanit = new TipiAeroplanit();
            aMarkaAeroplanit = new MarkaAeroplanit();
        }

        public int ID
        {
            get { return aID; }
            set { aID = value; }
        }

        public LinjaAjrore LinjaAjrore
        {
            get { return aLinjaAjrore; }
            set { aLinjaAjrore = value; }
        }

        public TipiAeroplanit TipiAeroplanit
        {
            get { return aTipiAeroplanit; }
            set { aTipiAeroplanit = value; }
        }

        public MarkaAeroplanit MarkaAeroplanit
        {
            get { return aMarkaAeroplanit; }
            set { aMarkaAeroplanit = value; }
        }

        public int NumriUleseve
        {
            get { return aNumriUleseve; }
            set { aNumriUleseve = value; }
        }

        public override string ToString()
        {
            return ID.ToString();
        }
    }
}
