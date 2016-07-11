using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BiznesLogjika;
using System.Data.SqlClient;
using System.Data;

namespace ShtresaETeDhenave
{
    public class RezervimiDB
    {
        private Rezervimi aRezervimi;

        public RezervimiDB(Rezervimi r)
        {
            aRezervimi = r;
        }

        public void Lexo(int ID)
        {
            SqlConnection lidhja = LidhjaMeBazen.KrijoLidhjeTeRe();

            try
            {
                SqlCommand komanda = new SqlCommand("RezervimiLexo", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@ID", ID);

                SqlDataReader lexuesi = komanda.ExecuteReader();

                while (lexuesi.Read())
                {
                    aRezervimi.ID = (int)lexuesi["ID"];

                    PerdoruesiAgjensionitDB padb = new PerdoruesiAgjensionitDB(aRezervimi.PerdoruesiAgjensionit);
                    padb.Lexo((int)lexuesi["PerdoruesiAgjensionitID"]);

                    FluturimiDB fdb = new FluturimiDB(aRezervimi.Fluturimi);
                    fdb.Lexo((int)lexuesi["FluturimiID"]);

                    UdhetariDB udb = new UdhetariDB(aRezervimi.Udhetari);
                    udb.Lexo((int)lexuesi["UdhetariID"]);

                    UlesjaDB uldb = new UlesjaDB(aRezervimi.Ulesja);
                    uldb.Lexo((int)lexuesi["UlesjaID"]);

                    aRezervimi.LlojiRezervimit = (LlojiIRezervimit)lexuesi["LlojiRezervimit"];
                    aRezervimi.Cmimi = (decimal)lexuesi["Cmimi"];
                }
            }
            finally
            {
                lidhja.Close();
            }
        }

        public void Shkruaj()
        {
            SqlConnection lidhja = LidhjaMeBazen.KrijoLidhjeTeRe();

            try
            {
                SqlCommand komanda = new SqlCommand("RezervimiShkruaj", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@PerdoruesiAgjensionitID", aRezervimi.PerdoruesiAgjensionit.ID);
                komanda.Parameters.AddWithValue("@FluturimiID", aRezervimi.Fluturimi.ID);
                komanda.Parameters.AddWithValue("@UdhetariID", aRezervimi.Udhetari.ID);
                komanda.Parameters.AddWithValue("@UlesjaID", aRezervimi.Ulesja.ID);
                komanda.Parameters.AddWithValue("@LlojiRezervimit", (int)aRezervimi.LlojiRezervimit);
                komanda.Parameters.AddWithValue("@Cmimi", aRezervimi.Cmimi);

                aRezervimi.ID = (int)komanda.ExecuteScalar();
            }
            finally
            {
                lidhja.Close();
            }
        }

        public void Ndrysho()
        {
            SqlConnection lidhja = LidhjaMeBazen.KrijoLidhjeTeRe();

            try
            {
                SqlCommand komanda = new SqlCommand("RezervimiNdrysho", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@ID", aRezervimi.ID);
                komanda.Parameters.AddWithValue("@PerdoruesiAgjensionitID", aRezervimi.PerdoruesiAgjensionit.ID);
                komanda.Parameters.AddWithValue("@FluturimiID", aRezervimi.Fluturimi.ID);
                komanda.Parameters.AddWithValue("@UdhetariID", aRezervimi.Udhetari.ID);
                komanda.Parameters.AddWithValue("@UlesjaID", aRezervimi.Ulesja.ID);
                komanda.Parameters.AddWithValue("@LlojiRezervimit", (int)aRezervimi.LlojiRezervimit);
                komanda.Parameters.AddWithValue("@Cmimi", aRezervimi.Cmimi);

                komanda.ExecuteNonQuery();
            }
            finally
            {
                lidhja.Close();
            }
        }

        public void Fshi()
        {
            SqlConnection lidhja = LidhjaMeBazen.KrijoLidhjeTeRe();

            try
            {
                SqlCommand komanda = new SqlCommand("RezervimiFshi", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@ID", aRezervimi.ID);

                komanda.ExecuteNonQuery();
            }
            finally
            {
                lidhja.Close();
            }
        }
    }
}
