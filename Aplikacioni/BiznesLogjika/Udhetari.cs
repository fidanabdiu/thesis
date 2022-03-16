namespace BiznesLogjika
{
    public class Udhetari : Personi
    {
        private PerdoruesiAgjensionit aPerdoruesiAgjensionit;

        public Udhetari()
        {
            aPerdoruesiAgjensionit = new PerdoruesiAgjensionit();
        }

        public PerdoruesiAgjensionit PerdoruesiAgjensionit 
        {
            get { return aPerdoruesiAgjensionit; }
            set { aPerdoruesiAgjensionit = value; }
        }

        public override string ToString()
        {
            return Emri + " " + Mbiemri;
        }
    }
}
