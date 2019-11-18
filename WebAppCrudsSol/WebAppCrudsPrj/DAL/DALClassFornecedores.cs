using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAppCrudsPrj.DAL
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
            Modelo.Fornecedores aFornecedores;
            List<Modelo.Fornecedores> aListFornecedores = new List<Modelo.Fornecedores>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Fornecedor";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read()) 
                {
                    
                    aFornecedores = new Modelo.Fornecedores(
                        Convert.ToInt32(dr["id"].ToString()),
                        dr["nome"].ToString(),
                        dr["email"].ToString(),
                        dr["telefone"].ToString() 
                        );
                    aListFornecedores.Add(aFornecedores);
                }


            }
            dr.Close();
            conn.Close();
            return aListFornecedores;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(Modelo.Fornecedores obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("DELETE FROM Fornecedor WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", obj.id);
            
            cmd.ExecuteNonQuery();

        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Fornecedores obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("INSERT INTO Fornecedor (nome, email, telefone) VALUES(@nome, @email, @telefone)", conn);
            cmd.Parameters.AddWithValue("@nome", obj.nome);
            cmd.Parameters.AddWithValue("@email", obj.email);
            cmd.Parameters.AddWithValue("@telefone", obj.telefone);
            
            cmd.ExecuteNonQuery();

        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Fornecedores obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("UPDATE Fornecedor SET nome = @nome, email = @email, telefone = @telefone  WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", obj.id);
            cmd.Parameters.AddWithValue("@nome", obj.nome);
            cmd.Parameters.AddWithValue("@email", obj.email);
            cmd.Parameters.AddWithValue("@telefone", obj.telefone);

            
            cmd.ExecuteNonQuery();
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Fornecedores> Select(int id)
        {
            Modelo.Fornecedores aFornecedores;
            List<Modelo.Fornecedores> aListFornecedores = new List<Modelo.Fornecedores>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Fornecedor WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read()) 
                {
                    aFornecedores = new Modelo.Fornecedores(
                        Convert.ToInt32(dr["id"].ToString()),
                        dr["nome"].ToString(),
                        dr["email"].ToString(),
                        dr["telefone"].ToString()
                        );
                    aListFornecedores.Add(aFornecedores);
                }
            }
            dr.Close();
            conn.Close();

            return aListFornecedores;
        }
    }
}