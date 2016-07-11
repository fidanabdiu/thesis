using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BiznesLogjika;
using System.Data.SqlClient;
using System.Data;

namespace ShtresaETeDhenave
{
    public class PerdoruesitAgjensionitDB
    {
        private List<PerdoruesiAgjensionit> aPerdoruesit;

        public PerdoruesitAgjensionitDB(List<PerdoruesiAgjensionit> lp)
        {
            aPerdoruesit = lp;
        }

        public void Lexo(int AgjensioniID)
        {
            SqlConnection lidhja = LidhjaMeBazen.KrijoLidhjeTeRe();

            try
            {
                SqlCommand komanda = new SqlCommand("PerdoruesitAgjensionitLexoSipasAgjensionit", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@AgjensioniID", AgjensioniID);

                SqlDataReader lexuesi = komanda.ExecuteReader();

                while (lexuesi.Read())
                {
                    PerdoruesiAgjensionit p = new PerdoruesiAgjensionit();

                    p.ID = (int)lexuesi["ID"];
                    p.Emri = (string)lexuesi["Emri"];
                    p.Mbiemri = (string)lexuesi["Mbiemri"];
                    p.NumriIdentifikues = (string)lexuesi["NumriIdentifikues"];
                    p.DokumentiIdentifikues = (DokumentiIdentifikues)lexuesi["DokumentiIdentifikues"];
                    p.Datelindja = (DateTime)lexuesi["Datelindja"];
                    p.Vendlindja = (string)lexuesi["Vendlindja"];
                    p.Vendbanimi = (string)lexuesi["Vendbanimi"];
                    p.Adresa = (string)lexuesi["Adresa"];
                    p.TelefoniFiks = (string)lexuesi["TelefoniFiks"];
                    p.TelefoniMobil = (string)lexuesi["TelefoniMobil"];
                    p.Emaili = (string)lexuesi["Emaili"];

                    AgjensioniDB adb = new AgjensioniDB(p.Agjensioni);
                    adb.Lexo((int)lexuesi["AgjensioniID"]);

                    p.Pseudonimi = (string)lexuesi["Pseudonimi"];
                    p.Fjalekalimi = (string)lexuesi["Fjalekalimi"];
                    p.Privilegji = (Privilegji)lexuesi["Privilegji"];

                    aPerdoruesit.Add(p);
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
                SqlCommand komanda = new SqlCommand("PerdoruesitAgjensionitLexo", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@fjalakyce", fjalakyce);

                SqlDataReader lexuesi = komanda.ExecuteReader();

                while (lexuesi.Read())
                {
                    PerdoruesiAgjensionit p = new PerdoruesiAgjensionit();

                    p.ID = (int)lexuesi["ID"];
                    p.Emri = (string)lexuesi["Emri"];
                    p.Mbiemri = (string)lexuesi["Mbiemri"];
                    p.NumriIdentifikues = (string)lexuesi["NumriIdentifikues"];
                    p.DokumentiIdentifikues = (DokumentiIdentifikues)lexuesi["DokumentiIdentifikues"];
                    p.Datelindja = (DateTime)lexuesi["Datelindja"];
                    p.Vendlindja = (string)lexuesi["Vendlindja"];
                    p.Vendbanimi = (string)lexuesi["Vendbanimi"];
                    p.Adresa = (string)lexuesi["Adresa"];
                    p.TelefoniFiks = (string)lexuesi["TelefoniFiks"];
                    p.TelefoniMobil = (string)lexuesi["TelefoniMobil"];
                    p.Emaili = (string)lexuesi["Emaili"];

                    AgjensioniDB adb = new AgjensioniDB(p.Agjensioni);
                    adb.Lexo((int)lexuesi["AgjensioniID"]);

                    p.Pseudonimi = (string)lexuesi["Pseudonimi"];
                    p.Fjalekalimi = (string)lexuesi["Fjalekalimi"];
                    p.Privilegji = (Privilegji)lexuesi["Privilegji"];

                    aPerdoruesit.Add(p);
                }
            }
            finally
            {
                lidhja.Close();
            }
        }
    }
}
