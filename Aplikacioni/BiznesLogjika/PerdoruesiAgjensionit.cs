namespace BiznesLogjika
{
    public class PerdoruesiAgjensionit : Personi
    {
        private Agjensioni aAgjensioni;
        private string aPseudonimi;
        private string aFjalekalimi;
        private Privilegji aPrivilegji;

        public PerdoruesiAgjensionit()
        {
            aAgjensioni = new Agjensioni();
            aFjalekalimi = "000";
        }

        public Agjensioni Agjensioni
        {
            get { return aAgjensioni; }
            set { aAgjensioni = value; }
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
