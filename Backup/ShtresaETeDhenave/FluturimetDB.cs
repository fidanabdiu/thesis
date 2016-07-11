using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BiznesLogjika;
using System.Data.SqlClient;
using System.Data;

namespace ShtresaETeDhenave
{
    public class FluturimetDB
    {
        private List<Fluturimi> aFluturimet;

        public FluturimetDB(List<Fluturimi> lf)
        {
            aFluturimet = lf;
        }

        public void Lexo(FluturimiAnuluar FluturimiAnuluar)
        {
            SqlConnection lidhja = LidhjaMeBazen.KrijoLidhjeTeRe();

            try
            {
                SqlCommand komanda = new SqlCommand("FluturimetLexoSipasStatusit", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@FluturimiAnuluar", FluturimiAnuluar);

                SqlDataReader lexuesi = komanda.ExecuteReader();

                while (lexuesi.Read())
                {
                    Fluturimi f = new Fluturimi();

                    f.ID = (int)lexuesi["ID"];

                    AeroplaniDB adb = new AeroplaniDB(f.Aeroplani);
                    adb.Lexo((int)lexuesi["AeroplaniID"]);

                    QytetiDB qdb = new QytetiDB(f.Qyteti);
                    qdb.Lexo((int)lexuesi["QytetiID"]);

                    f.DataNisjes = (DateTime)lexuesi["DataNisjes"];
                    f.OraNisjes = (DateTime)lexuesi["OraNisjes"];

                    PerdoruesiAeroportitDB padb = new PerdoruesiAeroportitDB(f.PerdoruesiAeroportit);
                    padb.Lexo((int)lexuesi["PerdoruesiAeroportitID"]);

                    f.FluturimiAnuluar = (FluturimiAnuluar)lexuesi["FluturimiAnuluar"];
                    f.Cmimi = (decimal)lexuesi["Cmimi"];
                    f.CmimiKthyes = (decimal)lexuesi["CmimiKthyes"];

                    aFluturimet.Add(f);
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
                SqlCommand komanda = new SqlCommand("FluturimetLexo", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@fjalakyce", fjalakyce);

                SqlDataReader lexuesi = komanda.ExecuteReader();

                while (lexuesi.Read())
                {
                    Fluturimi f = new Fluturimi();

                    f.ID = (int)lexuesi["ID"];

                    AeroplaniDB adb = new AeroplaniDB(f.Aeroplani);
                    adb.Lexo((int)lexuesi["AeroplaniID"]);

                    QytetiDB qdb = new QytetiDB(f.Qyteti);
                    qdb.Lexo((int)lexuesi["QytetiID"]);

                    f.DataNisjes = (DateTime)lexuesi["DataNisjes"];
                    f.OraNisjes = (DateTime)lexuesi["OraNisjes"];

                    PerdoruesiAeroportitDB padb = new PerdoruesiAeroportitDB(f.PerdoruesiAeroportit);
                    padb.Lexo((int)lexuesi["PerdoruesiAeroportitID"]);

                    f.FluturimiAnuluar = (FluturimiAnuluar)lexuesi["FluturimiAnuluar"];
                    f.Cmimi = (decimal)lexuesi["Cmimi"];
                    f.CmimiKthyes = (decimal)lexuesi["CmimiKthyes"];

                    aFluturimet.Add(f);
                }
            }
            finally
            {
                lidhja.Close();
            }
        }
    }
}
