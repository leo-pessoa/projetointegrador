using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAppCruds.DAL
{
    public class DALClassFornecedores
    {
        string connectionString = "";

        public DALClassFornecedores()
        {
            connectionString = ConfigurationManager.ConnectionStrings["SGEDConnectionString"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]

        public List<Modelo.Fornecedores> SelectAll()
        {
            // Variavel para armazenar um livro
            Modelo.Fornecedores aFornecedores;
            // Cria Lista Vazia
            List<Modelo.Fornecedores> aListFornecedores = new List<Modelo.Fornecedores>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "SELECT * FROM Fornecedor";
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            // Le titulo do livro do resultado e apresenta no segundo rótulo
            if (dr.HasRows)
            {
                while (dr.Read()) // Le o proximo registro
                {
                    // Cria objeto com dados lidos do banco de dados
                    aFornecedores = new Modelo.Fornecedores(
                        Convert.ToInt32(dr["id"].ToString()),
                        dr["nome"].ToString(),
                        dr["email"].ToString(),
                        dr["telefone"].ToString(),
                        Convert.ToInt32(dr["produto_fornecido"].ToString())
                        );
                    // Adiciona o livro lido à lista
                    aListFornecedores.Add(aFornecedores);
                }


            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();
            return aListFornecedores;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(Modelo.Fornecedores obj)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("DELETE FROM Fornecedor WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", obj.id);

            // Executa Comando
            cmd.ExecuteNonQuery();

        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Fornecedores obj)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("INSERT INTO Fornecedor (id, nome, email, telefone, produto_fornecido) VALUES(@id, @nome, @email, @telefone, @produto_fornecido)", conn);
            cmd.Parameters.AddWithValue("@id", obj.id);
            cmd.Parameters.AddWithValue("@nome", obj.nome);
            cmd.Parameters.AddWithValue("@email", obj.email);
            cmd.Parameters.AddWithValue("@telefone", obj.telefone);
            cmd.Parameters.AddWithValue("@produto_fornecido", obj.produto_fornecido);

            // Executa Comando
            cmd.ExecuteNonQuery();

        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Fornecedores obj)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("UPDATE Fornecedor SET id = @id, nome = @nome, email = @email, telefone = @telefone, produto_fornecido = @produto_fornecido  WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", obj.id);
            cmd.Parameters.AddWithValue("@nome", obj.nome);
            cmd.Parameters.AddWithValue("@email", obj.email);
            cmd.Parameters.AddWithValue("@telefone", obj.telefone);
            cmd.Parameters.AddWithValue("@produto_fornecido", obj.produto_fornecido);


            // Executa Comando
            cmd.ExecuteNonQuery();
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Fornecedores> Select(int id)
        {
            // Variavel para armazenar um livro
            Modelo.Fornecedores aFornecedores;
            // Cria Lista Vazia
            List<Modelo.Fornecedores> aListFornecedores = new List<Modelo.Fornecedores>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "SELECT * FROM Fornecedor WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            // Le titulo do livro do resultado e apresenta no segundo rótulo
            if (dr.HasRows)
            {
                while (dr.Read()) // Le o proximo registro
                {
                    // Cria objeto com dados lidos do banco de dados
                    aFornecedores = new Modelo.Fornecedores(
                        Convert.ToInt32(dr["id"].ToString()),
                        dr["nome"].ToString(),
                        dr["email"].ToString(),
                        dr["telefone"].ToString(),
                        Convert.ToInt32(dr["produto_fornecido"].ToString())
                        );
                    // Adiciona o livro lido à lista
                    aListFornecedores.Add(aFornecedores);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return aListFornecedores;
        }
    }
}