using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BiznesLogjika;
using System.Data.SqlClient;
using System.Data;

namespace ShtresaETeDhenave
{
    public class QytetiDB
    {        
        private Qyteti aQyteti;

        public QytetiDB(Qyteti q)
        {
            aQyteti = q;
        }

        public void Lexo(int ID)
        {
            SqlConnection lidhja = LidhjaMeBazen.KrijoLidhjeTeRe();

            try
            {
                SqlCommand komanda = new SqlCommand("QytetiLexo", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@ID", ID);

                SqlDataReader lexuesi = komanda.ExecuteReader();

                while (lexuesi.Read())
                {
                    aQyteti.ID = (int)lexuesi["ID"];
                    aQyteti.Emri = (string)lexuesi["Emri"];

                    ShtetiDB shdb = new ShtetiDB(aQyteti.Shteti);
                    shdb.Lexo((int)lexuesi["ShtetiID"]);
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
                SqlCommand komanda = new SqlCommand("QytetiShkruaj", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@Emri", aQyteti.Emri);
                komanda.Parameters.AddWithValue("@ShtetiID", aQyteti.Shteti.ID);

                aQyteti.ID = (int)komanda.ExecuteScalar();
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
                SqlCommand komanda = new SqlCommand("QytetiNdrysho", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@ID", aQyteti.ID);
                komanda.Parameters.AddWithValue("@Emri", aQyteti.Emri);
                komanda.Parameters.AddWithValue("@ShtetiID", aQyteti.Shteti.ID);

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
                SqlCommand komanda = new SqlCommand("QytetiFshi", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@ID", aQyteti.ID);

                komanda.ExecuteNonQuery();
            }
            finally
            {
                lidhja.Close();
            }
        }
    }
}