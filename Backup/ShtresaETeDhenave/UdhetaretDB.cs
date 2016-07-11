using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BiznesLogjika;
using System.Data.SqlClient;
using System.Data;

namespace ShtresaETeDhenave
{
    public class UdhetaretDB
    {
        private List<Udhetari> aUdhetaret;

        public UdhetaretDB(List<Udhetari> lu)
        {
            aUdhetaret = lu;
        }
        
        public void Lexo(string fjalakyce)
        {
            SqlConnection lidhja = LidhjaMeBazen.KrijoLidhjeTeRe();

            try
            {
                SqlCommand komanda = new SqlCommand("UdhetaretLexo", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@fjalakyce", fjalakyce);

                SqlDataReader lexuesi = komanda.ExecuteReader();

                while (lexuesi.Read())
                {
                    Udhetari u = new Udhetari();
                    
                    u.ID = (int)lexuesi["ID"];
                    u.Emri = (string)lexuesi["Emri"];
                    u.Mbiemri = (string)lexuesi["Mbiemri"];
                    u.NumriIdentifikues = (string)lexuesi["NumriIdentifikues"];
                    u.DokumentiIdentifikues = (DokumentiIdentifikues)lexuesi["DokumentiIdentifikues"];
                    u.Datelindja = (DateTime)lexuesi["Datelindja"];
                    u.Vendlindja = (string)lexuesi["Vendlindja"];
                    u.Vendbanimi = (string)lexuesi["Vendbanimi"];
                    u.Adresa = (string)lexuesi["Adresa"];
                    u.TelefoniFiks = (string)lexuesi["TelefoniFiks"];
                    u.TelefoniMobil = (string)lexuesi["TelefoniMobil"];
                    u.Emaili = (string)lexuesi["Emaili"];

                    PerdoruesiAgjensionitDB padb = new PerdoruesiAgjensionitDB(u.PerdoruesiAgjensionit);
                    padb.Lexo((int)lexuesi["PerdoruesiAgjensionitID"]);

                    aUdhetaret.Add(u);
                }
            }
            finally
            {
                lidhja.Close();
            }
        }
    }
}