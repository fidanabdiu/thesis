using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BiznesLogjika;
using System.Data.SqlClient;
using System.Data;

namespace ShtresaETeDhenave
{
    public class PerdoruesitAeroportitDB
    {
        private List<PerdoruesiAeroportit> aPerdoruesit;

        public PerdoruesitAeroportitDB(List<PerdoruesiAeroportit> lp)
        {
            aPerdoruesit = lp;
        }
        
        public void Lexo(string fjalakyce)
        {
            SqlConnection lidhja = LidhjaMeBazen.KrijoLidhjeTeRe();

            try
            {
                SqlCommand komanda = new SqlCommand("PerdoruesitAeroportitLexo", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@fjalakyce", fjalakyce);

                SqlDataReader lexuesi = komanda.ExecuteReader();

                while (lexuesi.Read())
                {
                    PerdoruesiAeroportit p = new PerdoruesiAeroportit();

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
