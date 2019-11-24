using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAppCrudsPrj.DAL
{
    public class DALClassProdutos
    {
        string connectionString = "";

        public DALClassProdutos()
        {
            connectionString = ConfigurationManager.ConnectionStrings["SGEDConnectionString"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]

        public List<Modelo.Produtos> SelectAll()
        {
            Modelo.Produtos aProdutos;
            List<Modelo.Produtos> aListProdutos = new List<Modelo.Produtos>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Produtos";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aProdutos = new Modelo.Produtos(
                        Convert.ToInt32(dr["id"].ToString()),
                        dr["nome"].ToString(),
                        double.Parse(dr["valor"].ToString()),
                        dr["descricao"].ToString(),
                        Convert.ToInt32(dr["quantidade"].ToString()),
                        Convert.ToInt32(dr["fornecedor_id"].ToString())
                        );
                    aListProdutos.Add(aProdutos);
                }


            }
            dr.Close();
            conn.Close();
            return aListProdutos;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(Modelo.Produtos obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("DELETE FROM Produtos WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", obj.id);
            
            cmd.ExecuteNonQuery();

        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Produtos obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("INSERT INTO Produtos (nome, valor, descricao, quantidade, fornecedor_id) VALUES(@nome, @valor, @descricao, @quantidade, @fornecedor_id)", conn);
            cmd.Parameters.AddWithValue("@nome", obj.nome);
            cmd.Parameters.AddWithValue("@valor", obj.valor);
            cmd.Parameters.AddWithValue("@descricao", obj.descricao);
            cmd.Parameters.AddWithValue("@quantidade", obj.quantidade);
            cmd.Parameters.AddWithValue("@fornecedor_id", obj.fornecedor_id);
            
            cmd.ExecuteNonQuery();

        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Produtos obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("UPDATE Produtos SET nome = @nome, valor = @valor, descricao = @descricao, quantidade = @quantidade, fornecedor_id = @fornecedor_id WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", obj.id);
            cmd.Parameters.AddWithValue("@nome", obj.nome);
            cmd.Parameters.AddWithValue("@valor", obj.valor);
            cmd.Parameters.AddWithValue("@descricao", obj.descricao);
            cmd.Parameters.AddWithValue("@quantidade", obj.quantidade);
            cmd.Parameters.AddWithValue("@fornecedor_id", obj.fornecedor_id);
            
            cmd.ExecuteNonQuery();
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Produtos> Select(int id)
        {
            Modelo.Produtos aProdutos;
            List<Modelo.Produtos> aListProdutos = new List<Modelo.Produtos>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Produtos WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aProdutos = new Modelo.Produtos(
                        Convert.ToInt32(dr["id"].ToString()),
                        dr["nome"].ToString(),
                        double.Parse(dr["valor"].ToString()),
                        dr["descricao"].ToString(),
                        Convert.ToInt32(dr["quantidade"].ToString()),
                        Convert.ToInt32(dr["fornecedor_id"].ToString())
                        );
                    aListProdutos.Add(aProdutos);
                }
            }
            dr.Close();
            conn.Close();

            return aListProdutos;
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Produtos> Select(String nome)
        {
            Modelo.Produtos aProdutos;
            List<Modelo.Produtos> aListProdutos = new List<Modelo.Produtos>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Produtos WHERE nome like '%" + nome + "%' AND quantidade != 0 ";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aProdutos = new Modelo.Produtos(
                        Convert.ToInt32(dr["id"].ToString()),
                        dr["nome"].ToString(),
                         double.Parse(dr["valor"].ToString()),
                        dr["descricao"].ToString(),
                        Convert.ToInt32(dr["quantidade"].ToString()),
                        Convert.ToInt32(dr["fornecedor_id"].ToString())
                        );
                    aListProdutos.Add(aProdutos);
                }
            }
            dr.Close();
            conn.Close();

            return aListProdutos;
        }




    }
}