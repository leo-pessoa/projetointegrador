using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAppCrudsPrj.DAL
{
    public class DALClassCPF
    {
        string connectionString = "";

        public DALClassCPF()
        {
            connectionString = ConfigurationManager.ConnectionStrings["SGEDConnectionString"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
            public List<Modelo.Clientes> Select(String cpf)
            {
                Modelo.Clientes aClientes;
                List<Modelo.Clientes> aListClientes = new List<Modelo.Clientes>();
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                if (cpf == null) cpf = "";
                cmd.CommandText = "SELECT * FROM Usuario WHERE cpf ='"+cpf+"'";
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read()) 
                    {
                        aClientes = new Modelo.Clientes(
                            Convert.ToInt32(dr["id"].ToString()),
                            dr["nome"].ToString(),
                            dr["cpf"].ToString(),
                            dr["perfil"].ToString()
                            );
                        aListClientes.Add(aClientes);
                    }
                }
                dr.Close();
                conn.Close();

                return aListClientes;
            }
        }
   }
