using System.ComponentModel;
using System.Web.Services;
using BiznesLogjika;
using System.Collections.Generic;
using ShtresaETeDhenave;

namespace UebSherbimi
{
    /// <summary>
    /// Summary description for WS
    /// </summary>
    [WebService(Namespace = "http://www.fidanabdiu.netfirms.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WS : WebService
    {
        [WebMethod]
        public PerdoruesiAgjensionit Kycu(string pseudonimi, string fjalekalimi)
        {
            List<PerdoruesiAgjensionit> lpa = new List<PerdoruesiAgjensionit>();

            PerdoruesitAgjensionitDB padb = new PerdoruesitAgjensionitDB(lpa);
            padb.Lexo("");

            foreach (PerdoruesiAgjensionit pa in lpa)
            {
                if (pa.Pseudonimi == pseudonimi && pa.Fjalekalimi == fjalekalimi)
                    return pa;
            }

            return null;
        }

        [WebMethod]
        public PerdoruesiAgjensionit PerdoruesiAgjensionitShkruaj(PerdoruesiAgjensionit pa)
        {
            PerdoruesiAgjensionitDB padb = new PerdoruesiAgjensionitDB(pa);
            padb.Shkruaj();

            return pa;
        }

        [WebMethod]
        public PerdoruesiAgjensionit PerdoruesiAgjensionitNdrysho(PerdoruesiAgjensionit pa)
        {
            PerdoruesiAgjensionitDB padb = new PerdoruesiAgjensionitDB(pa);
            padb.Ndrysho();

            return pa;
        }

        [WebMethod]
        public PerdoruesiAgjensionit PerdoruesiAgjensionitLexo(int ID)
        {
            PerdoruesiAgjensionit pa = new PerdoruesiAgjensionit();

            PerdoruesiAgjensionitDB padb = new PerdoruesiAgjensionitDB(pa);
            padb.Lexo(ID);

            return pa;
        }

        [WebMethod]
        public void PerdoruesiAgjensionitFshi(PerdoruesiAgjensionit pa)
        {
            PerdoruesiAgjensionitDB padb = new PerdoruesiAgjensionitDB(pa);
            padb.Fshi();
        }

        [WebMethod]
        public List<PerdoruesiAgjensionit> PerdoruesiAgjensionitLexoSipasAgjensionit(int AgjensioniID)
        {
            List<PerdoruesiAgjensionit> lpa = new List<PerdoruesiAgjensionit>();

            PerdoruesitAgjensionitDB padb = new PerdoruesitAgjensionitDB(lpa);
            padb.Lexo(AgjensioniID);

            return lpa;
        }

        [WebMethod]
        public List<Fluturimi> FluturimetLexo(string fjalakyce)
        {
            List<Fluturimi> lf = new List<Fluturimi>();

            FluturimetDB fdb = new FluturimetDB(lf);
            fdb.Lexo(fjalakyce);

            return lf;
        }

        [WebMethod]
        public Rezervimi RezervimiShkruaj(Rezervimi r)
        {
            RezervimiDB rdb = new RezervimiDB(r);
            rdb.Shkruaj();

            return r;
        }

        [WebMethod]
        public Rezervimi RezervimiNdrysho(Rezervimi r)
        {
            RezervimiDB rdb = new RezervimiDB(r);
            rdb.Ndrysho();

            return r;
        }

        [WebMethod]
        public Rezervimi RezervimiLexo(int ID)
        {
            Rezervimi r = new Rezervimi();

            RezervimiDB rdb = new RezervimiDB(r);
            rdb.Lexo(ID);

            return r;
        }

        [WebMethod]
        public void RezervimiFshi(Rezervimi r)
        {
            RezervimiDB rdb = new RezervimiDB(r);
            rdb.Fshi();
        }

        [WebMethod]
        public List<Rezervimi> RezervimetLexoSipasAgjensionit(int AgjensioniID)
        {
            List<Rezervimi> lr = new List<Rezervimi>();

            RezervimetDB rdb = new RezervimetDB(lr);
            rdb.Lexo(AgjensioniID);

            return lr;
        }

        [WebMethod]
        public Udhetari UdhetariShkruaj(Udhetari u)
        {
            UdhetariDB udb = new UdhetariDB(u);
            udb.Shkruaj();

            return u;
        }

        [WebMethod]
        public Udhetari UdhetariNdrysho(Udhetari u)
        {
            UdhetariDB udb = new UdhetariDB(u);
            udb.Ndrysho();

            return u;
        }

        [WebMethod]
        public Udhetari UdhetariLexo(int ID)
        {
            Udhetari u = new Udhetari();

            UdhetariDB udb = new UdhetariDB(u);
            udb.Lexo(ID);

            return u;
        }

        [WebMethod]
        public List<Udhetari> UdhetaretLexo(string fjalakyce)
        {
            List<Udhetari> lu = new List<Udhetari>();

            UdhetaretDB udb = new UdhetaretDB(lu);
            udb.Lexo(fjalakyce);

            return lu;
        }

        [WebMethod]
        public List<Ulesja> UlesetLexoSipasAeroplanit(int AeroplaniID)
        {
            List<Ulesja> lu = new List<Ulesja>();

            UlesetDB udb = new UlesetDB(lu);
            udb.Lexo(AeroplaniID);

            return lu;
        }

        [WebMethod]
        public void UdhetariFshi(Udhetari u)
        {
            UdhetariDB udb = new UdhetariDB(u);
            udb.Fshi();
        }

        [WebMethod]
        public Ulesja UlesjaNdrysho(Ulesja u)
        {
            UlesjaDB udb = new UlesjaDB(u);
            udb.Ndrysho();

            return u;
        }

        [WebMethod]
        public List<Ulesja> UlesetLexoSipasStatusit(int AeroplaniID, UlesjaEZene UlesjaEZene)
        {
            List<Ulesja> lu = new List<Ulesja>();

            UlesetDB udb = new UlesetDB(lu);
            udb.Lexo(AeroplaniID, UlesjaEZene);

            return lu;
        }

        [WebMethod]
        public List<Fluturimi> FluturimetLexoSipasStatusit(FluturimiAnuluar FluturimiAnuluar)
        {
            List<Fluturimi> lf = new List<Fluturimi>();

            FluturimetDB fdb = new FluturimetDB(lf);
            fdb.Lexo(FluturimiAnuluar);

            return lf;
        }

        [WebMethod]
        public bool LexoUlesetLira(int AeroplaniID, UlesjaEZene UlesjaEZene)
        {
            List<Ulesja> lu = new List<Ulesja>();

            UlesetDB udb = new UlesetDB(lu);
            bool ka = udb.LexoUlesetLira(AeroplaniID, UlesjaEZene.JO);

            return ka;
        }
    }
}
