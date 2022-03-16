using System.Collections.Generic;
using BiznesLogjika;
using System.Data.SqlClient;
using System.Data;

namespace ShtresaETeDhenave
{
    public class TipetAeroplanaveDB
    {
        private List<TipiAeroplanit> aTipetAeroplanave;

        public TipetAeroplanaveDB(List<TipiAeroplanit> lta)
        {
            aTipetAeroplanave = lta;
        }

        public void Lexo(string fjalakyce)
        {
            SqlConnection lidhja = LidhjaMeBazen.KrijoLidhjeTeRe();

            try
            {
                SqlCommand komanda = new SqlCommand("TipetAeroplanaveLexo", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@fjalakyce", fjalakyce);

                SqlDataReader lexuesi = komanda.ExecuteReader();

                while (lexuesi.Read())
                {
                    TipiAeroplanit ta = new TipiAeroplanit();

                    ta.ID = (int)lexuesi["ID"];
                    ta.Emri = (string)lexuesi["Emri"];

                    aTipetAeroplanave.Add(ta);
                }
            }
            finally
            {
                lidhja.Close();
            }
        }
    }
}
