using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BiznesLogjika;
using System.Data.SqlClient;
using System.Data;

namespace ShtresaETeDhenave
{
    public class ShtetiDB
    {
        private Shteti aShteti;

        public ShtetiDB(Shteti sh)
        {
            aShteti = sh;
        }

        public void Lexo(int ID)
        {
            SqlConnection lidhja = LidhjaMeBazen.KrijoLidhjeTeRe();

            try
            {
                SqlCommand komanda = new SqlCommand("ShtetiLexo", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@ID", ID);

                SqlDataReader lexuesi = komanda.ExecuteReader();

                while (lexuesi.Read())
                {
                    aShteti.ID = (int)lexuesi["ID"];
                    aShteti.Emri = (string)lexuesi["Emri"];
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
                SqlCommand komanda = new SqlCommand("ShtetiShkruaj", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@Emri", aShteti.Emri);

                aShteti.ID = (int)komanda.ExecuteScalar();
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
                SqlCommand komanda = new SqlCommand("ShtetiNdrysho", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@ID", aShteti.ID);
                komanda.Parameters.AddWithValue("@Emri", aShteti.Emri);

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
                SqlCommand komanda = new SqlCommand("ShtetiFshi", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@ID", aShteti.ID);

                komanda.ExecuteNonQuery();
            }
            finally
            {
                lidhja.Close();
            }
        }
    }
}