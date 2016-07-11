using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BiznesLogjika;
using System.Data.SqlClient;
using System.Data;

namespace ShtresaETeDhenave
{
    public class AeroplaniDB
    {
        private Aeroplani aAeroplani;

        public AeroplaniDB(Aeroplani a)
        {
            aAeroplani = a;
        }

        public void Lexo(int ID)
        {
            SqlConnection lidhja = LidhjaMeBazen.KrijoLidhjeTeRe();

            try
            {
                SqlCommand komanda = new SqlCommand("AeroplaniLexo", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@ID", ID);

                SqlDataReader lexuesi = komanda.ExecuteReader();

                while (lexuesi.Read())
                {
                    aAeroplani.ID = (int)lexuesi["ID"];
                    
                    LinjaAjroreDB ladb = new LinjaAjroreDB(aAeroplani.LinjaAjrore);
                    ladb.Lexo((int)lexuesi["LinjaAjroreID"]);

                    TipiAeroplanitDB tadb = new TipiAeroplanitDB(aAeroplani.TipiAeroplanit);
                    tadb.Lexo((int)lexuesi["TipiAeroplanitID"]);

                    MarkaAeroplanitDB madb = new MarkaAeroplanitDB(aAeroplani.MarkaAeroplanit);
                    madb.Lexo((int)lexuesi["MarkaAeroplanitID"]);

                    aAeroplani.NumriUleseve = (int)lexuesi["NumriUleseve"];
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
                SqlCommand komanda = new SqlCommand("AeroplaniShkruaj", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@LinjaAjroreID", aAeroplani.LinjaAjrore.ID);
                komanda.Parameters.AddWithValue("@TipiAeroplanitID", aAeroplani.TipiAeroplanit.ID);
                komanda.Parameters.AddWithValue("@MarkaAeroplanitID", aAeroplani.MarkaAeroplanit.ID);
                komanda.Parameters.AddWithValue("@NumriUleseve", aAeroplani.NumriUleseve);

                aAeroplani.ID = (int)komanda.ExecuteScalar();
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
                SqlCommand komanda = new SqlCommand("AeroplaniNdrysho", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@ID", aAeroplani.ID);
                komanda.Parameters.AddWithValue("@LinjaAjroreID", aAeroplani.LinjaAjrore.ID);
                komanda.Parameters.AddWithValue("@TipiAeroplanitID", aAeroplani.TipiAeroplanit.ID);
                komanda.Parameters.AddWithValue("@MarkaAeroplanitID", aAeroplani.MarkaAeroplanit.ID);
                komanda.Parameters.AddWithValue("@NumriUleseve", aAeroplani.NumriUleseve);

                komanda.ExecuteNonQuery();

                UlesjaDB udb = new UlesjaDB(aAeroplani.ID);
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
                SqlCommand komanda = new SqlCommand("AeroplaniFshi", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@ID", aAeroplani.ID);

                komanda.ExecuteNonQuery();
            }
            finally
            {
                lidhja.Close();
            }
        }
    }
}
