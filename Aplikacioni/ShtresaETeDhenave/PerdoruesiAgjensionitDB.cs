using System;
using BiznesLogjika;
using System.Data.SqlClient;
using System.Data;

namespace ShtresaETeDhenave
{
    public class PerdoruesiAgjensionitDB
    {
        private PerdoruesiAgjensionit aPerdoruesi;

        public PerdoruesiAgjensionitDB(PerdoruesiAgjensionit p)
        {
            aPerdoruesi = p;
        }
        
        public void Lexo(int ID)
        {
            SqlConnection lidhja = LidhjaMeBazen.KrijoLidhjeTeRe();

            try
            {
                SqlCommand komanda = new SqlCommand("PerdoruesiAgjensionitLexo", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@ID", ID);

                SqlDataReader lexuesi = komanda.ExecuteReader();

                while (lexuesi.Read())
                {
                    aPerdoruesi.ID = (int)lexuesi["ID"];
                    aPerdoruesi.Emri = (string)lexuesi["Emri"];
                    aPerdoruesi.Mbiemri = (string)lexuesi["Mbiemri"];
                    aPerdoruesi.NumriIdentifikues = (string)lexuesi["NumriIdentifikues"];
                    aPerdoruesi.DokumentiIdentifikues = (DokumentiIdentifikues)lexuesi["DokumentiIdentifikues"];
                    aPerdoruesi.Datelindja = (DateTime)lexuesi["Datelindja"];
                    aPerdoruesi.Vendlindja = (string)lexuesi["Vendlindja"];
                    aPerdoruesi.Vendbanimi = (string)lexuesi["Vendbanimi"];
                    aPerdoruesi.Adresa = (string)lexuesi["Adresa"];
                    aPerdoruesi.TelefoniFiks = (string)lexuesi["TelefoniFiks"];
                    aPerdoruesi.TelefoniMobil = (string)lexuesi["TelefoniMobil"];
                    aPerdoruesi.Emaili = (string)lexuesi["Emaili"];

                    AgjensioniDB adb = new AgjensioniDB(aPerdoruesi.Agjensioni);
                    adb.Lexo((int)lexuesi["AgjensioniID"]);
                    
                    aPerdoruesi.Pseudonimi = (string)lexuesi["Pseudonimi"];
                    aPerdoruesi.Fjalekalimi = (string)lexuesi["Fjalekalimi"];
                    aPerdoruesi.Privilegji = (Privilegji)lexuesi["Privilegji"];
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
                SqlCommand komanda = new SqlCommand("PerdoruesiAgjensionitShkruaj", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@Emri", (aPerdoruesi.Emri == null ? "" : aPerdoruesi.Emri));
                komanda.Parameters.AddWithValue("@Mbiemri", (aPerdoruesi.Mbiemri == null ? "" : aPerdoruesi.Mbiemri));
                komanda.Parameters.AddWithValue("@NumriIdentifikues", (aPerdoruesi.NumriIdentifikues == null ? "" : aPerdoruesi.NumriIdentifikues));
                komanda.Parameters.AddWithValue("@DokumentiIdentifikues", (int)aPerdoruesi.DokumentiIdentifikues);
                komanda.Parameters.AddWithValue("@Datelindja", aPerdoruesi.Datelindja);
                komanda.Parameters.AddWithValue("@Vendlindja", (aPerdoruesi.Vendlindja == null ? "" : aPerdoruesi.Vendlindja));
                komanda.Parameters.AddWithValue("@Vendbanimi", (aPerdoruesi.Vendbanimi == null ? "" : aPerdoruesi.Vendbanimi));
                komanda.Parameters.AddWithValue("@Adresa", (aPerdoruesi.Adresa == null ? "" : aPerdoruesi.Adresa));
                komanda.Parameters.AddWithValue("@TelefoniFiks", (aPerdoruesi.TelefoniFiks == null ? "" : aPerdoruesi.TelefoniFiks));
                komanda.Parameters.AddWithValue("@TelefoniMobil", (aPerdoruesi.TelefoniMobil == null ? "" : aPerdoruesi.TelefoniMobil));
                komanda.Parameters.AddWithValue("@Emaili", (aPerdoruesi.Emaili == null ? "" : aPerdoruesi.Emaili));
                komanda.Parameters.AddWithValue("@AgjensioniID", aPerdoruesi.Agjensioni.ID);
                komanda.Parameters.AddWithValue("@Pseudonimi", (aPerdoruesi.Pseudonimi == null ? "" : aPerdoruesi.Pseudonimi));
                komanda.Parameters.AddWithValue("@Fjalekalimi", (aPerdoruesi.Fjalekalimi == null ? "" : aPerdoruesi.Fjalekalimi));
                komanda.Parameters.AddWithValue("@Privilegji", (int)aPerdoruesi.Privilegji);

                aPerdoruesi.ID = (int)komanda.ExecuteScalar();
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
                SqlCommand komanda = new SqlCommand("PerdoruesiAgjensionitNdrysho", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@ID", aPerdoruesi.ID);
                komanda.Parameters.AddWithValue("@Emri", (aPerdoruesi.Emri == null ? "" : aPerdoruesi.Emri));
                komanda.Parameters.AddWithValue("@Mbiemri", (aPerdoruesi.Mbiemri == null ? "" : aPerdoruesi.Mbiemri));
                komanda.Parameters.AddWithValue("@NumriIdentifikues", (aPerdoruesi.NumriIdentifikues == null ? "" : aPerdoruesi.NumriIdentifikues));
                komanda.Parameters.AddWithValue("@DokumentiIdentifikues", (int)aPerdoruesi.DokumentiIdentifikues);
                komanda.Parameters.AddWithValue("@Datelindja", aPerdoruesi.Datelindja);
                komanda.Parameters.AddWithValue("@Vendlindja", (aPerdoruesi.Vendlindja == null ? "" : aPerdoruesi.Vendlindja));
                komanda.Parameters.AddWithValue("@Vendbanimi", (aPerdoruesi.Vendbanimi == null ? "" : aPerdoruesi.Vendbanimi));
                komanda.Parameters.AddWithValue("@Adresa", (aPerdoruesi.Adresa == null ? "" : aPerdoruesi.Adresa));
                komanda.Parameters.AddWithValue("@TelefoniFiks", (aPerdoruesi.TelefoniFiks == null ? "" : aPerdoruesi.TelefoniFiks));
                komanda.Parameters.AddWithValue("@TelefoniMobil", (aPerdoruesi.TelefoniMobil == null ? "" : aPerdoruesi.TelefoniMobil));
                komanda.Parameters.AddWithValue("@Emaili", (aPerdoruesi.Emaili == null ? "" : aPerdoruesi.Emaili));
                komanda.Parameters.AddWithValue("@AgjensioniID", aPerdoruesi.Agjensioni.ID);
                komanda.Parameters.AddWithValue("@Pseudonimi", (aPerdoruesi.Pseudonimi == null ? "" : aPerdoruesi.Pseudonimi));
                komanda.Parameters.AddWithValue("@Fjalekalimi", (aPerdoruesi.Fjalekalimi == null ? "" : aPerdoruesi.Fjalekalimi));
                komanda.Parameters.AddWithValue("@Privilegji", (int)aPerdoruesi.Privilegji);

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
                SqlCommand komanda = new SqlCommand("PerdoruesiAgjensionitFshi", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@ID", aPerdoruesi.ID);

                komanda.ExecuteNonQuery();
            }
            finally
            {
                lidhja.Close();
            }
        }
    }
}
