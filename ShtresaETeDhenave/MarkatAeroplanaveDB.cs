using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BiznesLogjika;
using System.Data.SqlClient;
using System.Data;

namespace ShtresaETeDhenave
{
    public class MarkatAeroplanaveDB
    {
        private List<MarkaAeroplanit> aMarkatAeroplanave;

        public MarkatAeroplanaveDB(List<MarkaAeroplanit> lma)
        {
            aMarkatAeroplanave = lma;
        }

        public void Lexo(int TipiAeroplanitID)
        {
            SqlConnection lidhja = LidhjaMeBazen.KrijoLidhjeTeRe();

            try
            {
                SqlCommand komanda = new SqlCommand("MarkatAeroplanaveLexoSipasTipit", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@TipiAeroplanitID", TipiAeroplanitID);

                SqlDataReader lexuesi = komanda.ExecuteReader();

                while (lexuesi.Read())
                {
                    MarkaAeroplanit ma = new MarkaAeroplanit();

                    ma.ID = (int)lexuesi["ID"];

                    TipiAeroplanitDB tadb = new TipiAeroplanitDB(ma.TipiAeroplanit);
                    tadb.Lexo((int)lexuesi["TipiAeroplanitID"]);

                    ma.Emri = (string)lexuesi["Emri"];

                    aMarkatAeroplanave.Add(ma);
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
                SqlCommand komanda = new SqlCommand("MarkatAeroplanaveLexo", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@fjalakyce", fjalakyce);

                SqlDataReader lexuesi = komanda.ExecuteReader();

                while (lexuesi.Read())
                {
                    MarkaAeroplanit ma = new MarkaAeroplanit();

                    ma.ID = (int)lexuesi["ID"];

                    TipiAeroplanitDB tadb = new TipiAeroplanitDB(ma.TipiAeroplanit);
                    tadb.Lexo((int)lexuesi["TipiAeroplanitID"]);

                    ma.Emri = (string)lexuesi["Emri"];

                    aMarkatAeroplanave.Add(ma);
                }
            }
            finally
            {
                lidhja.Close();
            }
        }
    }
}
