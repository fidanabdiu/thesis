using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BiznesLogjika;
using System.Data.SqlClient;
using System.Data;

namespace ShtresaETeDhenave
{
    public class UdhetariDB
    {
        private Udhetari aUdhetari;

        public UdhetariDB(Udhetari u)
        {
            aUdhetari = u;
        }
        
        public void Lexo(int ID)
        {
            SqlConnection lidhja = LidhjaMeBazen.KrijoLidhjeTeRe();

            try
            {
                SqlCommand komanda = new SqlCommand("UdhetariLexo", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@ID", ID);

                SqlDataReader lexuesi = komanda.ExecuteReader();

                while (lexuesi.Read())
                {
                    aUdhetari.ID = (int)lexuesi["ID"];
                    aUdhetari.Emri = (string)lexuesi["Emri"];
                    aUdhetari.Mbiemri = (string)lexuesi["Mbiemri"];
                    aUdhetari.NumriIdentifikues = (string)lexuesi["NumriIdentifikues"];
                    aUdhetari.DokumentiIdentifikues = (DokumentiIdentifikues)lexuesi["DokumentiIdentifikues"];
                    aUdhetari.Datelindja = (DateTime)lexuesi["Datelindja"];
                    aUdhetari.Vendlindja = (string)lexuesi["Vendlindja"];
                    aUdhetari.Vendbanimi = (string)lexuesi["Vendbanimi"];
                    aUdhetari.Adresa = (string)lexuesi["Adresa"];
                    aUdhetari.TelefoniFiks = (string)lexuesi["TelefoniFiks"];
                    aUdhetari.TelefoniMobil = (string)lexuesi["TelefoniMobil"];
                    aUdhetari.Emaili = (string)lexuesi["Emaili"];

                    PerdoruesiAgjensionitDB padb = new PerdoruesiAgjensionitDB(aUdhetari.PerdoruesiAgjensionit);
                    padb.Lexo((int)lexuesi["PerdoruesiAgjensionitID"]);
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
                SqlCommand komanda = new SqlCommand("UdhetariShkruaj", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@Emri", (aUdhetari.Emri == null ? "" : aUdhetari.Emri));
                komanda.Parameters.AddWithValue("@Mbiemri", (aUdhetari.Mbiemri == null ? "" : aUdhetari.Mbiemri));
                komanda.Parameters.AddWithValue("@NumriIdentifikues", (aUdhetari.NumriIdentifikues == null ? "" : aUdhetari.NumriIdentifikues));
                komanda.Parameters.AddWithValue("@DokumentiIdentifikues", (int)aUdhetari.DokumentiIdentifikues);
                komanda.Parameters.AddWithValue("@Datelindja", aUdhetari.Datelindja);
                komanda.Parameters.AddWithValue("@Vendlindja", (aUdhetari.Vendlindja == null ? "" : aUdhetari.Vendlindja));
                komanda.Parameters.AddWithValue("@Vendbanimi", (aUdhetari.Vendbanimi == null ? "" : aUdhetari.Vendbanimi));
                komanda.Parameters.AddWithValue("@Adresa", (aUdhetari.Adresa == null ? "" : aUdhetari.Adresa));
                komanda.Parameters.AddWithValue("@TelefoniFiks", (aUdhetari.TelefoniFiks == null ? "" : aUdhetari.TelefoniFiks));
                komanda.Parameters.AddWithValue("@TelefoniMobil", (aUdhetari.TelefoniMobil == null ? "" : aUdhetari.TelefoniMobil));
                komanda.Parameters.AddWithValue("@Emaili", (aUdhetari.Emaili == null ? "" : aUdhetari.Emaili));
                komanda.Parameters.AddWithValue("@PerdoruesiAgjensionitID", aUdhetari.PerdoruesiAgjensionit.ID);

                aUdhetari.ID = (int)komanda.ExecuteScalar();
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
                SqlCommand komanda = new SqlCommand("UdhetariNdrysho", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@ID", aUdhetari.ID);
                komanda.Parameters.AddWithValue("@Emri", (aUdhetari.Emri == null ? "" : aUdhetari.Emri));
                komanda.Parameters.AddWithValue("@Mbiemri", (aUdhetari.Mbiemri == null ? "" : aUdhetari.Mbiemri));
                komanda.Parameters.AddWithValue("@NumriIdentifikues", (aUdhetari.NumriIdentifikues == null ? "" : aUdhetari.NumriIdentifikues));
                komanda.Parameters.AddWithValue("@DokumentiIdentifikues", (int)aUdhetari.DokumentiIdentifikues);
                komanda.Parameters.AddWithValue("@Datelindja", aUdhetari.Datelindja);
                komanda.Parameters.AddWithValue("@Vendlindja", (aUdhetari.Vendlindja == null ? "" : aUdhetari.Vendlindja));
                komanda.Parameters.AddWithValue("@Vendbanimi", (aUdhetari.Vendbanimi == null ? "" : aUdhetari.Vendbanimi));
                komanda.Parameters.AddWithValue("@Adresa", (aUdhetari.Adresa == null ? "" : aUdhetari.Adresa));
                komanda.Parameters.AddWithValue("@TelefoniFiks", (aUdhetari.TelefoniFiks == null ? "" : aUdhetari.TelefoniFiks));
                komanda.Parameters.AddWithValue("@TelefoniMobil", (aUdhetari.TelefoniMobil == null ? "" : aUdhetari.TelefoniMobil));
                komanda.Parameters.AddWithValue("@Emaili", (aUdhetari.Emaili == null ? "" : aUdhetari.Emaili));
                komanda.Parameters.AddWithValue("@PerdoruesiAgjensionitID", aUdhetari.PerdoruesiAgjensionit.ID);

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
                SqlCommand komanda = new SqlCommand("UdhetariFshi", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@ID", aUdhetari.ID);

                komanda.ExecuteNonQuery();
            }
            finally
            {
                lidhja.Close();
            }
        }
    }
}
