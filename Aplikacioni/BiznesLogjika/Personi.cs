using System;

namespace BiznesLogjika
{
    public abstract class Personi
    {
        private int aID;
        private string aEmri;
        private string aMbiemri;
        private string aNumriIdentifikues;
        private DokumentiIdentifikues aDokumentiIdentifikues;
        private DateTime aDatelindja;
        private string aVendlindja;
        private string aVendbanimi;
        private string aAdresa;
        private string aTelefoniFiks;
        private string aTelefoniMobil;
        private string aEmaili;

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

        public string Mbiemri
        {
            get { return aMbiemri; }
            set { aMbiemri = value; }
        }

        public string NumriIdentifikues
        {
            get { return aNumriIdentifikues; }
            set { aNumriIdentifikues = value; }
        }

        public DokumentiIdentifikues DokumentiIdentifikues
        {
            get { return aDokumentiIdentifikues; }
            set { aDokumentiIdentifikues = value; }
        }

        public DateTime Datelindja
        {
            get { return aDatelindja; }
            set { aDatelindja = value; }
        }

        public string Vendlindja
        {
            get { return aVendlindja; }
            set { aVendlindja = value; }
        }

        public string Vendbanimi
        {
            get { return aVendbanimi; }
            set { aVendbanimi = value; }
        }

        public string Adresa
        {
            get { return aAdresa; }
            set { aAdresa = value; }
        }

        public string TelefoniFiks
        {
            get { return aTelefoniFiks; }
            set { aTelefoniFiks = value; }
        }

        public string TelefoniMobil
        {
            get { return aTelefoniMobil; }
            set { aTelefoniMobil = value; }
        }

        public string Emaili
        {
            get { return aEmaili; }
            set { aEmaili = value; }
        }
    }
}
