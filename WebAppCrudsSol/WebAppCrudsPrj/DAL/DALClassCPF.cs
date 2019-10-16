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
                // Variavel para armazenar um livro
                Modelo.Clientes aClientes;
                // Cria Lista Vazia
                List<Modelo.Clientes> aListClientes = new List<Modelo.Clientes>();
                // Cria Conexão com banco de dados
                SqlConnection conn = new SqlConnection(connectionString);
                // Abre conexão com o banco de dados
                conn.Open();
                // Cria comando SQL
                SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
                if (cpf == null) cpf = "";
                cmd.CommandText = "SELECT * FROM Usuario WHERE cpf ='"+cpf+"'";
                // Executa comando, gerando objeto DbDataReader
                SqlDataReader dr = cmd.ExecuteReader();
                // Le titulo do livro do resultado e apresenta no segundo rótulo
                if (dr.HasRows)
                {
                    while (dr.Read()) // Le o proximo registro
                    {
                        // Cria objeto com dados lidos do banco de dados
                        aClientes = new Modelo.Clientes(
                            Convert.ToInt32(dr["id"].ToString()),
                            dr["nome"].ToString(),
                            dr["cpf"].ToString(),
                            dr["perfil"].ToString()
                            );
                        // Adiciona o livro lido à lista
                        aListClientes.Add(aClientes);
                    }
                }
                // Fecha DataReader
                dr.Close();
                // Fecha Conexão
                conn.Close();

                return aListClientes;
            }
        }
   }
