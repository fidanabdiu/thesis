using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BiznesLogjika;
using System.Data.SqlClient;
using System.Data;

namespace ShtresaETeDhenave
{
    public class MarkaAeroplanitDB
    {
        private MarkaAeroplanit aMarkaAeroplanit;

        public MarkaAeroplanitDB(MarkaAeroplanit ma)
        {
            aMarkaAeroplanit = ma;
        }

        public void Lexo(int ID)
        {
            SqlConnection lidhja = LidhjaMeBazen.KrijoLidhjeTeRe();

            try
            {
                SqlCommand komanda = new SqlCommand("MarkaAeroplanitLexo", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@ID", ID);

                SqlDataReader lexuesi = komanda.ExecuteReader();

                while (lexuesi.Read())
                {
                    aMarkaAeroplanit.ID = (int)lexuesi["ID"];

                    TipiAeroplanitDB tadb = new TipiAeroplanitDB(aMarkaAeroplanit.TipiAeroplanit);
                    tadb.Lexo((int)lexuesi["TipiAeroplanitID"]);

                    aMarkaAeroplanit.Emri = (string)lexuesi["Emri"];
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
                SqlCommand komanda = new SqlCommand("MarkaAeroplanitShkruaj", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@TipiAeroplanitID", aMarkaAeroplanit.TipiAeroplanit.ID);
                komanda.Parameters.AddWithValue("@Emri", aMarkaAeroplanit.Emri);

                aMarkaAeroplanit.ID = (int)komanda.ExecuteScalar();
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
                SqlCommand komanda = new SqlCommand("MarkaAeroplanitNdrysho", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@ID", aMarkaAeroplanit.ID);
                komanda.Parameters.AddWithValue("@TipiAeroplanitID", aMarkaAeroplanit.TipiAeroplanit.ID);
                komanda.Parameters.AddWithValue("@Emri", aMarkaAeroplanit.Emri);

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
                SqlCommand komanda = new SqlCommand("MarkaAeroplanitFshi", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@ID", aMarkaAeroplanit.ID);

                komanda.ExecuteNonQuery();
            }
            finally
            {
                lidhja.Close();
            }
        }
    }
}
