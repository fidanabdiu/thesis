using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BiznesLogjika;
using System.Data.SqlClient;
using System.Data;

namespace ShtresaETeDhenave
{
    public class AgjensionetDB
    {
        private List<Agjensioni> aAgjensionet;

        public AgjensionetDB(List<Agjensioni> la)
        {
            aAgjensionet = la;
        }

        public void Lexo(string fjalakyce)
        {
            SqlConnection lidhja = LidhjaMeBazen.KrijoLidhjeTeRe();

            try
            {
                SqlCommand komanda = new SqlCommand("AgjensionetLexo", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@fjalakyce", fjalakyce);

                SqlDataReader lexuesi = komanda.ExecuteReader();

                while (lexuesi.Read())
                {
                    Agjensioni a = new Agjensioni();

                    a.ID = (int)lexuesi["ID"];
                    a.Emri = (string)lexuesi["Emri"];

                    aAgjensionet.Add(a);
                }
            }
            finally
            {
                lidhja.Close();
            }
        }
    }
}