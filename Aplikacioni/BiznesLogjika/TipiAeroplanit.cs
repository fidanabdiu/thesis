﻿namespace BiznesLogjika
{
    public class TipiAeroplanit
    {
        private int aID;
        private string aEmri;

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

        public override string ToString()
        {
            return aEmri;
        }
    }
}
