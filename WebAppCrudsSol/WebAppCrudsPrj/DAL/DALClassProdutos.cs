﻿using System;
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
            // Variavel para armazenar um livro
            Modelo.Produtos aProdutos;
            // Cria Lista Vazia
            List<Modelo.Produtos> aListProdutos = new List<Modelo.Produtos>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "SELECT * FROM Produtos";
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            // Le titulo do livro do resultado e apresenta no segundo rótulo
            if (dr.HasRows)
            {
                while (dr.Read()) // Le o proximo registro
                {
                    // Cria objeto com dados lidos do banco de dados
                    aProdutos = new Modelo.Produtos(
                        Convert.ToInt32(dr["id"].ToString()),
                        dr["nome"].ToString(),
                        double.Parse(dr["valor"].ToString()),
                        dr["descricao"].ToString(),
                        Convert.ToInt32(dr["quantidade"].ToString()),
                        Convert.ToInt32(dr["fornecedor_id"].ToString())
                        );
                    // Adiciona o livro lido à lista
                    aListProdutos.Add(aProdutos);
                }


            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();
            return aListProdutos;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(Modelo.Produtos obj)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("DELETE FROM Produtos WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", obj.id);

            // Executa Comando
            cmd.ExecuteNonQuery();

        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Produtos obj)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("INSERT INTO Produtos (nome, valor, descricao, quantidade, fornecedor_id) VALUES(@nome, @valor, @descricao, @quantidade, @fornecedor_id)", conn);
            cmd.Parameters.AddWithValue("@nome", obj.nome);
            cmd.Parameters.AddWithValue("@valor", obj.valor);
            cmd.Parameters.AddWithValue("@descricao", obj.descricao);
            cmd.Parameters.AddWithValue("@quantidade", obj.quantidade);
            cmd.Parameters.AddWithValue("@fornecedor_id", obj.fornecedor_id);

            // Executa Comando
            cmd.ExecuteNonQuery();

        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Produtos obj)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("UPDATE Produtos SET nome = @nome, valor = @valor, descricao = @descricao, quantidade = @quantidade, fornecedor_id = @fornecedor_id WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", obj.id);
            cmd.Parameters.AddWithValue("@nome", obj.nome);
            cmd.Parameters.AddWithValue("@valor", obj.valor);
            cmd.Parameters.AddWithValue("@descricao", obj.descricao);
            cmd.Parameters.AddWithValue("@quantidade", obj.quantidade);
            cmd.Parameters.AddWithValue("@fornecedor_id", obj.fornecedor_id);

            // Executa Comando
            cmd.ExecuteNonQuery();
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Produtos> Select(int id)
        {
            // Variavel para armazenar um livro
            Modelo.Produtos aProdutos;
            // Cria Lista Vazia
            List<Modelo.Produtos> aListProdutos = new List<Modelo.Produtos>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "SELECT * FROM Produtos WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            // Le titulo do livro do resultado e apresenta no segundo rótulo
            if (dr.HasRows)
            {
                while (dr.Read()) // Le o proximo registro
                {
                    // Cria objeto com dados lidos do banco de dados
                    aProdutos = new Modelo.Produtos(
                        Convert.ToInt32(dr["id"].ToString()),
                        dr["nome"].ToString(),
                        double.Parse(dr["valor"].ToString()),
                        dr["descricao"].ToString(),
                        Convert.ToInt32(dr["quantidade"].ToString()),
                        Convert.ToInt32(dr["fornecedor_id"].ToString())
                        );
                    // Adiciona o livro lido à lista
                    aListProdutos.Add(aProdutos);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return aListProdutos;
        }


        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Produtos> Select(String nome)
        {
            // Variavel para armazenar um livro
            Modelo.Produtos aProdutos;
            // Cria Lista Vazia
            List<Modelo.Produtos> aListProdutos = new List<Modelo.Produtos>();
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand cmd = conn.CreateCommand();
            // define SQL do comando
            cmd.CommandText = "SELECT * FROM Produtos WHERE nome like '%" + nome + "%' AND quantidade != 0 ";
            // Executa comando, gerando objeto DbDataReader
            SqlDataReader dr = cmd.ExecuteReader();
            // Le titulo do livro do resultado e apresenta no segundo rótulo
            if (dr.HasRows)
            {
                while (dr.Read()) // Le o proximo registro
                {
                    // Cria objeto com dados lidos do banco de dados
                    aProdutos = new Modelo.Produtos(
                        Convert.ToInt32(dr["id"].ToString()),
                        dr["nome"].ToString(),
                         double.Parse(dr["valor"].ToString()),
                        dr["descricao"].ToString(),
                        Convert.ToInt32(dr["quantidade"].ToString()),
                        Convert.ToInt32(dr["fornecedor_id"].ToString())
                        );
                    // Adiciona o livro lido à lista
                    aListProdutos.Add(aProdutos);
                }
            }
            // Fecha DataReader
            dr.Close();
            // Fecha Conexão
            conn.Close();

            return aListProdutos;
        }




    }
}