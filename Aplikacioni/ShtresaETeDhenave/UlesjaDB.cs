using BiznesLogjika;
using System.Data.SqlClient;
using System.Data;

namespace ShtresaETeDhenave
{
    public class UlesjaDB
    {
        private Ulesja aUlesja;

        public UlesjaDB(Ulesja u)
        {
            aUlesja = u;
        }

        public UlesjaDB(int AeroplaniID)
        {
            Fshi(AeroplaniID);
        }

        public void Lexo(int ID)
        {
            SqlConnection lidhja = LidhjaMeBazen.KrijoLidhjeTeRe();

            try
            {
                SqlCommand komanda = new SqlCommand("UlesjaLexo", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@ID", ID);

                SqlDataReader lexuesi = komanda.ExecuteReader();

                while (lexuesi.Read())
                {
                    aUlesja.ID = (int)lexuesi["ID"];
                    aUlesja.Numri = (int)lexuesi["Numri"];

                    AeroplaniDB adb = new AeroplaniDB(aUlesja.Aeroplani);
                    adb.Lexo((int)lexuesi["AeroplaniID"]);

                    aUlesja.UlesjaEZene = (UlesjaEZene)lexuesi["UlesjaEZene"];
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
                SqlCommand komanda = new SqlCommand("UlesjaShkruaj", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@Numri", aUlesja.Numri);
                komanda.Parameters.AddWithValue("@AeroplaniID", aUlesja.Aeroplani.ID);
                komanda.Parameters.AddWithValue("@UlesjaEZene", (int)aUlesja.UlesjaEZene);

                aUlesja.ID = (int)komanda.ExecuteScalar();
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
                SqlCommand komanda = new SqlCommand("UlesjaNdrysho", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@ID", aUlesja.ID);
                komanda.Parameters.AddWithValue("@Numri", aUlesja.Numri);
                komanda.Parameters.AddWithValue("@AeroplaniID", aUlesja.Aeroplani.ID);
                komanda.Parameters.AddWithValue("@UlesjaEZene", (int)aUlesja.UlesjaEZene);

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
                SqlCommand komanda = new SqlCommand("UlesjaFshi", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@ID", aUlesja.ID);

                komanda.ExecuteNonQuery();
            }
            finally
            {
                lidhja.Close();
            }
        }

        private void Fshi(int AeroplaniID)
        {
            SqlConnection lidhja = LidhjaMeBazen.KrijoLidhjeTeRe();

            try
            {
                SqlCommand komanda = new SqlCommand("UlesetFshiSipasAeroplanit", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@AeroplaniID", AeroplaniID);

                komanda.ExecuteNonQuery();
            }
            finally
            {
                lidhja.Close();
            }
        }
    }
}
