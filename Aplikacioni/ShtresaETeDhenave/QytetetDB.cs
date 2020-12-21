using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BiznesLogjika;
using System.Data.SqlClient;
using System.Data;

namespace ShtresaETeDhenave
{
    public class QytetetDB
    {
        private List<Qyteti> aQytetet;

        public QytetetDB(List<Qyteti> lq)
        {
            aQytetet = lq;
        }

        public void Lexo(int ShtetiID)
        {
            SqlConnection lidhja = LidhjaMeBazen.KrijoLidhjeTeRe();

            try
            {
                SqlCommand komanda = new SqlCommand("QytetetLexoSipasShtetit", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@ShtetiID", ShtetiID);

                SqlDataReader lexuesi = komanda.ExecuteReader();

                while (lexuesi.Read())
                {
                    Qyteti q = new Qyteti();

                    q.ID = (int)lexuesi["ID"];
                    q.Emri = (string)lexuesi["Emri"];

                    ShtetiDB shdb = new ShtetiDB(q.Shteti);
                    shdb.Lexo((int)lexuesi["ShtetiID"]);

                    aQytetet.Add(q);
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
                SqlCommand komanda = new SqlCommand("QytetetLexo", lidhja);
                komanda.CommandType = CommandType.StoredProcedure;

                komanda.Parameters.AddWithValue("@fjalakyce", fjalakyce);

                SqlDataReader lexuesi = komanda.ExecuteReader();

                while (lexuesi.Read())
                {
                    Qyteti q = new Qyteti();

                    q.ID = (int)lexuesi["ID"];
                    q.Emri = (string)lexuesi["Emri"];

                    ShtetiDB shdb = new ShtetiDB(q.Shteti);
                    shdb.Lexo((int)lexuesi["ShtetiID"]);

                    aQytetet.Add(q);
                }
            }
            finally
            {
                lidhja.Close();
            }
        }
    }
}