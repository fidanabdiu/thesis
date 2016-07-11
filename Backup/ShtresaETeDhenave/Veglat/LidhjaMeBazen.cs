using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace ShtresaETeDhenave
{
    public class LidhjaMeBazen
    {
        public static SqlConnection KrijoLidhjeTeRe()
        {
            SqlConnection lidhja = new SqlConnection(ConfigurationManager.ConnectionStrings["Lidhja"].ToString());

            try
            {
                lidhja.Open();
            }
            catch
            {
                lidhja.Close();
                throw new Exception("Lidhja me bazën e të dhënave nuk mund të realizohet");
            }

            return lidhja;
        }
    }
}
