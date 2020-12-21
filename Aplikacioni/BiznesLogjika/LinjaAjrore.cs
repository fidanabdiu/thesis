using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiznesLogjika
{
    public class LinjaAjrore
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
