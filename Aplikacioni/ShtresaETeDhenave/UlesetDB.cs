using System.Collections.Generic;
using BiznesLogjika;
using System.Data.SqlClient;
using System.Data;

namespace ShtresaETeDhenave
{
    public class UlesetDB
    {
        private List<Ulesja> aUleset;

        public UlesetDB(List<Ulesja> lu)
        {
            aUleset = lu;
        }

        public bool LexoUlesetLira(int AeroplaniID, UlesjaEZene UlesjaEZene)
        {
            int numri;
            
            SqlConnection lidhja = LidhjaMeBazen.KrijoLidhjeTeRe();

            try
            {
                SqlCommand komanda = new SqlCommand("UlesetLiraLexo", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@AeroplaniID", AeroplaniID);
                komanda.Parameters.AddWithValue("@UlesjaEZene", UlesjaEZene);

                numri = (int)komanda.ExecuteScalar();
            }
            finally
            {
                lidhja.Close();
            }

            if (numri > 0)
                return true;
            else
                return false;
        }

        public void Lexo(int AeroplaniID, UlesjaEZene UlesjaEZene)
        {
            SqlConnection lidhja = LidhjaMeBazen.KrijoLidhjeTeRe();

            try
            {
                SqlCommand komanda = new SqlCommand("UlesetLexoSipasStatusit", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@AeroplaniID", AeroplaniID);
                komanda.Parameters.AddWithValue("@UlesjaEZene", UlesjaEZene);

                SqlDataReader lexuesi = komanda.ExecuteReader();

                while (lexuesi.Read())
                {
                    Ulesja u = new Ulesja();

                    u.ID = (int)lexuesi["ID"];
                    u.Numri = (int)lexuesi["Numri"];

                    AeroplaniDB adb = new AeroplaniDB(u.Aeroplani);
                    adb.Lexo((int)lexuesi["AeroplaniID"]);

                    u.UlesjaEZene = (UlesjaEZene)lexuesi["UlesjaEZene"];

                    aUleset.Add(u);
                }
            }
            finally
            {
                lidhja.Close();
            }
        }
        
        public void Lexo(int AeroplaniID)
        {
            SqlConnection lidhja = LidhjaMeBazen.KrijoLidhjeTeRe();

            try
            {
                SqlCommand komanda = new SqlCommand("UlesetLexoSipasAeroplanit", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@AeroplaniID", AeroplaniID);

                SqlDataReader lexuesi = komanda.ExecuteReader();

                while (lexuesi.Read())
                {
                    Ulesja u = new Ulesja();

                    u.ID = (int)lexuesi["ID"];
                    u.Numri = (int)lexuesi["Numri"];

                    AeroplaniDB adb = new AeroplaniDB(u.Aeroplani);
                    adb.Lexo((int)lexuesi["AeroplaniID"]);

                    u.UlesjaEZene = (UlesjaEZene)lexuesi["UlesjaEZene"];

                    aUleset.Add(u);
                }
            }
            finally
            {
                lidhja.Close();
            }
        }

        public void Lexo(string fjalakyce)
        {
        }

    }
}
