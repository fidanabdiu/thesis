namespace BiznesLogjika
{
    public class Qyteti
    {
        private int aID;
        private string aEmri;
        private Shteti aShteti;

        public Qyteti()
        {
            aShteti = new Shteti();
        }

        public int ID
        {
            get { return aID; }
            set { aID = value; }
        }

        public string Emri
        {
            get { return aEmri; }
            set { aEmri = value; }
        }

        public Shteti Shteti
        {
            get { return aShteti; }
            set { aShteti = value; }
        }

        public override string ToString()
        {
            return aEmri;
        }
    }
}
