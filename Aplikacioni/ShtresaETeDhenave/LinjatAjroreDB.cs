using System.Collections.Generic;
using BiznesLogjika;
using System.Data.SqlClient;
using System.Data;

namespace ShtresaETeDhenave
{
    public class LinjatAjroreDB
    {
        private List<LinjaAjrore> aLinjatAjrore;

        public LinjatAjroreDB(List<LinjaAjrore> lla)
        {
            aLinjatAjrore = lla;
        }

        public void Lexo(string fjalakyce)
        {
            SqlConnection lidhja = LidhjaMeBazen.KrijoLidhjeTeRe();

            try
            {
                SqlCommand komanda = new SqlCommand("LinjatAjroreLexo", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@fjalakyce", fjalakyce);

                SqlDataReader lexuesi = komanda.ExecuteReader();

                while (lexuesi.Read())
                {
                    LinjaAjrore la = new LinjaAjrore();

                    la.ID = (int)lexuesi["ID"];
                    la.Emri = (string)lexuesi["Emri"];

                    aLinjatAjrore.Add(la);
                }
            }
            finally
            {
                lidhja.Close();
            }
        }
    }
}
