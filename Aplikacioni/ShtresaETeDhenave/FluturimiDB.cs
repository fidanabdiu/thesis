using System;
using BiznesLogjika;
using System.Data.SqlClient;
using System.Data;

namespace ShtresaETeDhenave
{
    public class FluturimiDB
    {
        private Fluturimi aFluturimi;

        public FluturimiDB(Fluturimi f)
        {
            aFluturimi = f;
        }

        public void Lexo(int ID)
        {
            SqlConnection lidhja = LidhjaMeBazen.KrijoLidhjeTeRe();

            try
            {
                SqlCommand komanda = new SqlCommand("FluturimiLexo", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@ID", ID);

                SqlDataReader lexuesi = komanda.ExecuteReader();

                while (lexuesi.Read())
                {
                    aFluturimi.ID = (int)lexuesi["ID"];

                    AeroplaniDB adb = new AeroplaniDB(aFluturimi.Aeroplani);
                    adb.Lexo((int)lexuesi["AeroplaniID"]);

                    QytetiDB qdb = new QytetiDB(aFluturimi.Qyteti);
                    qdb.Lexo((int)lexuesi["QytetiID"]);

                    aFluturimi.DataNisjes = (DateTime)lexuesi["DataNisjes"];
                    aFluturimi.OraNisjes = (DateTime)lexuesi["OraNisjes"];

                    PerdoruesiAeroportitDB padb = new PerdoruesiAeroportitDB(aFluturimi.PerdoruesiAeroportit);
                    padb.Lexo((int)lexuesi["PerdoruesiAeroportitID"]);

                    aFluturimi.FluturimiAnuluar = (FluturimiAnuluar)lexuesi["FluturimiAnuluar"];
                    aFluturimi.Cmimi = (decimal)lexuesi["Cmimi"];
                    aFluturimi.CmimiKthyes = (decimal)lexuesi["CmimiKthyes"];
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
                SqlCommand komanda = new SqlCommand("FluturimiShkruaj", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@AeroplaniID", aFluturimi.Aeroplani.ID);
                komanda.Parameters.AddWithValue("@QytetiID", aFluturimi.Qyteti.ID);
                komanda.Parameters.AddWithValue("@DataNisjes", aFluturimi.DataNisjes);
                komanda.Parameters.AddWithValue("@OraNisjes", aFluturimi.OraNisjes);
                komanda.Parameters.AddWithValue("@PerdoruesiAeroportitID", aFluturimi.PerdoruesiAeroportit.ID);
                komanda.Parameters.AddWithValue("@FluturimiAnuluar", (int)aFluturimi.FluturimiAnuluar);
                komanda.Parameters.AddWithValue("@Cmimi", aFluturimi.Cmimi);
                komanda.Parameters.AddWithValue("@CmimiKthyes", aFluturimi.CmimiKthyes);

                aFluturimi.ID = (int)komanda.ExecuteScalar();
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
                SqlCommand komanda = new SqlCommand("FluturimiNdrysho", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@ID", aFluturimi.ID);
                komanda.Parameters.AddWithValue("@AeroplaniID", aFluturimi.Aeroplani.ID);
                komanda.Parameters.AddWithValue("@QytetiID", aFluturimi.Qyteti.ID);
                komanda.Parameters.AddWithValue("@DataNisjes", aFluturimi.DataNisjes);
                komanda.Parameters.AddWithValue("@OraNisjes", aFluturimi.OraNisjes);
                komanda.Parameters.AddWithValue("@PerdoruesiAeroportitID", aFluturimi.PerdoruesiAeroportit.ID);
                komanda.Parameters.AddWithValue("@FluturimiAnuluar", (int)aFluturimi.FluturimiAnuluar);
                komanda.Parameters.AddWithValue("@Cmimi", aFluturimi.Cmimi);
                komanda.Parameters.AddWithValue("@CmimiKthyes", aFluturimi.CmimiKthyes);

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
                SqlCommand komanda = new SqlCommand("FluturimiFshi", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@ID", aFluturimi.ID);

                komanda.ExecuteNonQuery();
            }
            finally
            {
                lidhja.Close();
            }
        }
    }
}