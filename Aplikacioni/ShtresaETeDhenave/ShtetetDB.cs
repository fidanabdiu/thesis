using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BiznesLogjika;
using System.Data.SqlClient;
using System.Data;

namespace ShtresaETeDhenave
{
    public class ShtetetDB
    {
        private List<Shteti> aShtetet;

        public ShtetetDB(List<Shteti> lsh)
        {
            aShtetet = lsh;
        }

        public void Lexo(string fjalakyce)
        {
            SqlConnection lidhja = LidhjaMeBazen.KrijoLidhjeTeRe();

            try
            {
                SqlCommand komanda = new SqlCommand("ShtetetLexo", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@fjalakyce", fjalakyce);

                SqlDataReader lexuesi = komanda.ExecuteReader();

                while (lexuesi.Read())
                {
                    Shteti sh = new Shteti();

                    sh.ID = (int)lexuesi["ID"];
                    sh.Emri = (string)lexuesi["Emri"];

                    aShtetet.Add(sh);
                }
            }
            finally
            {
                lidhja.Close();
            }
        }
    }
}
