using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiznesLogjika
{
    public class MarkaAeroplanit
    {
        private int aID;
        private string aEmri;
        private TipiAeroplanit aTipiAeroplanit;

        public MarkaAeroplanit()
        {
            aTipiAeroplanit = new TipiAeroplanit();
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

        public TipiAeroplanit TipiAeroplanit
        {
            get { return aTipiAeroplanit; }
            set { aTipiAeroplanit = value; }
        }

        public override string ToString()
        {
            return aEmri;
        }
    }
}
