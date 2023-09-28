using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ScarpeApp.Models
{
    public static class DB
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString.ToString();
        private static readonly SqlConnection conn = new SqlConnection(connectionString);
        public static List<Prodotto> getProdotti()
        {

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM ScarpeTabella", conn);
                SqlDataReader sqlDataReader;
                conn.Open();
                List<Prodotto> Prodotti = new List<Prodotto>();
                sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Prodotto newProdotto = new Prodotto(
                        Convert.ToInt32(sqlDataReader["ID_Prodotto"]),
                        sqlDataReader["Nome"].ToString(),
                        Convert.ToDecimal(sqlDataReader["Prezzo"]),
                        sqlDataReader["Descrizione"].ToString(),
                        Convert.ToBoolean(sqlDataReader["InVendita"]),
                        sqlDataReader["ImmagineCopertina"].ToString(),
                        sqlDataReader["ImmagineAggiuntiva1"].ToString(),
                        sqlDataReader["ImmagineAggiuntiva2"].ToString()
                        );

                    Prodotti.Add(newProdotto);

                }

                return Prodotti;
            }
            catch (Exception ex)
            {
                return new List<Prodotto>();
            }
            finally { conn.Close(); }



        }

        public static Prodotto getProdotto(int id, List<Prodotto> prodotti)
        {

            Prodotto prodotto = new Prodotto();
            foreach (var item in prodotti)
            {
                if (item.Id_Prodotto == id)
                {
                    prodotto = item;

                    break;
                }
            }
            return prodotto;
        }


    }
}