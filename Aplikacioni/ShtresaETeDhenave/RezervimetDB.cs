using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BiznesLogjika;
using System.Data.SqlClient;
using System.Data;

namespace ShtresaETeDhenave
{
    public class RezervimetDB
    {
        private List<Rezervimi> aRezervimet;

        public RezervimetDB(List<Rezervimi> lr)
        {
            aRezervimet = lr;
        }

        public void Lexo(int AgjensioniID)
        {
            SqlConnection lidhja = LidhjaMeBazen.KrijoLidhjeTeRe();

            try
            {
                SqlCommand komanda = new SqlCommand("RezervimetLexoSipasAgjensionit", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@AgjensioniID", AgjensioniID);

                SqlDataReader lexuesi = komanda.ExecuteReader();

                while (lexuesi.Read())
                {
                    Rezervimi r = new Rezervimi();

                    r.ID = (int)lexuesi["ID"];

                    PerdoruesiAgjensionitDB padb = new PerdoruesiAgjensionitDB(r.PerdoruesiAgjensionit);
                    padb.Lexo((int)lexuesi["PerdoruesiAgjensionitID"]);

                    FluturimiDB fdb = new FluturimiDB(r.Fluturimi);
                    fdb.Lexo((int)lexuesi["FluturimiID"]);

                    UdhetariDB udb = new UdhetariDB(r.Udhetari);
                    udb.Lexo((int)lexuesi["UdhetariID"]);

                    UlesjaDB uldb = new UlesjaDB(r.Ulesja);
                    uldb.Lexo((int)lexuesi["UlesjaID"]);

                    r.LlojiRezervimit = (LlojiIRezervimit)lexuesi["LlojiRezervimit"];
                    r.Cmimi = (decimal)lexuesi["Cmimi"];

                    aRezervimet.Add(r);
                }
            }
            finally
            {
                lidhja.Close();
            }
        }

        public void Lexo(string fjalakyce)
        {
            SqlConnection lidhja = LidhjaMeBazen.KrijoLidhjeTeRe();

            try
            {
                SqlCommand komanda = new SqlCommand("RezervimetLexo", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@fjalakyce", fjalakyce);

                SqlDataReader lexuesi = komanda.ExecuteReader();

                while (lexuesi.Read())
                {
                    Rezervimi r = new Rezervimi();

                    r.ID = (int)lexuesi["ID"];

                    PerdoruesiAgjensionitDB padb = new PerdoruesiAgjensionitDB(r.PerdoruesiAgjensionit);
                    padb.Lexo((int)lexuesi["PerdoruesiAgjensionitID"]);

                    FluturimiDB fdb = new FluturimiDB(r.Fluturimi);
                    fdb.Lexo((int)lexuesi["FluturimiID"]);

                    UdhetariDB udb = new UdhetariDB(r.Udhetari);
                    udb.Lexo((int)lexuesi["UdhetariID"]);

                    UlesjaDB uldb = new UlesjaDB(r.Ulesja);
                    uldb.Lexo((int)lexuesi["UlesjaID"]);

                    r.LlojiRezervimit = (LlojiIRezervimit)lexuesi["LlojiRezervimit"];
                    r.Cmimi = (decimal)lexuesi["Cmimi"];

                    aRezervimet.Add(r);
                }
            }
            finally
            {
                lidhja.Close();
            }
        }
    }
}
