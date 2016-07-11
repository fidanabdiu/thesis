using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BiznesLogjika;
using System.Data.SqlClient;
using System.Data;

namespace ShtresaETeDhenave
{
    public class AeroplanatDB
    {
        private List<Aeroplani> aAeroplanat;

        public AeroplanatDB(List<Aeroplani> la)
        {
            aAeroplanat = la;
        }

        public void Lexo(int LinjaAjroreID)
        {
            SqlConnection lidhja = LidhjaMeBazen.KrijoLidhjeTeRe();

            try
            {
                SqlCommand komanda = new SqlCommand("AeroplanatLexoSipasLinjes", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@LinjaAjroreID", LinjaAjroreID);

                SqlDataReader lexuesi = komanda.ExecuteReader();

                while (lexuesi.Read())
                {
                    Aeroplani a = new Aeroplani();

                    a.ID = (int)lexuesi["ID"];

                    LinjaAjroreDB ladb = new LinjaAjroreDB(a.LinjaAjrore);
                    ladb.Lexo((int)lexuesi["LinjaAjroreID"]);

                    TipiAeroplanitDB tadb = new TipiAeroplanitDB(a.TipiAeroplanit);
                    tadb.Lexo((int)lexuesi["TipiAeroplanitID"]);

                    MarkaAeroplanitDB madb = new MarkaAeroplanitDB(a.MarkaAeroplanit);
                    madb.Lexo((int)lexuesi["MarkaAeroplanitID"]);

                    a.NumriUleseve = (int)lexuesi["NumriUleseve"];

                    aAeroplanat.Add(a);
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
                SqlCommand komanda = new SqlCommand("AeroplanatLexo", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@fjalakyce", fjalakyce);

                SqlDataReader lexuesi = komanda.ExecuteReader();

                while (lexuesi.Read())
                {
                    Aeroplani a = new Aeroplani();

                    a.ID = (int)lexuesi["ID"];

                    LinjaAjroreDB ladb = new LinjaAjroreDB(a.LinjaAjrore);
                    ladb.Lexo((int)lexuesi["LinjaAjroreID"]);

                    TipiAeroplanitDB tadb = new TipiAeroplanitDB(a.TipiAeroplanit);
                    tadb.Lexo((int)lexuesi["TipiAeroplanitID"]);

                    MarkaAeroplanitDB madb = new MarkaAeroplanitDB(a.MarkaAeroplanit);
                    madb.Lexo((int)lexuesi["MarkaAeroplanitID"]);

                    a.NumriUleseve = (int)lexuesi["NumriUleseve"];

                    aAeroplanat.Add(a);
                }
            }
            finally
            {
                lidhja.Close();
            }
        }
    }
}
