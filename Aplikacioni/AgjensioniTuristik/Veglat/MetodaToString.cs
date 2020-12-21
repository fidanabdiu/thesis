using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgjensioniTuristik.Veglat
{
    public class MetodaToString
    {
        private string aEmri;
        private object aObjekti;

        public MetodaToString(string e, object o)
        {
            aEmri = e;
            aObjekti = o;
        }

        public object Objekti
        {
            get { return aObjekti; }
        }

        public override string ToString()
        {
            return aEmri;
        }
    }
}
