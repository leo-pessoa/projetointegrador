﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAppCrudsPrj.DAL
{
    public class DalClassVendas
    {

        string connectionString = "";

        public DalClassVendas()
        {
            connectionString = ConfigurationManager.ConnectionStrings["SGEDConnectionString"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Venda obj)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("INSERT INTO Venda (id, verif_pago, data_venda) VALUES(@id, @verif_pago, @data_venda)", conn);
            cmd.Parameters.AddWithValue("@id", obj.id);
            cmd.Parameters.AddWithValue("@verif_pago", obj.pago);
            cmd.Parameters.AddWithValue("@data_venda", obj.data);
 

            // Executa Comando
            cmd.ExecuteNonQuery();

        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Venda> Select(int id)
        {

            Modelo.Venda aVenda;
            List<Modelo.Venda> aListVenda = new List<Modelo.Venda>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Venda";
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aVenda = new Modelo.Venda(
                        Convert.ToInt32(dr["id"].ToString()),
                        dr["verif_pago"].ToString(),
                        Convert.ToDateTime(dr["data_venda"])
                        );
                    aListVenda.Add(aVenda);
                }

            }
            dr.Close();
            conn.Close();
            return aListVenda;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Venda> SelectAll()
        {

            Modelo.Venda aVenda;
            List<Modelo.Venda> aListVenda = new List<Modelo.Venda>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Venda";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aVenda = new Modelo.Venda(
                        Convert.ToInt32(dr["id"].ToString()),
                        dr["verif_pago"].ToString(),
                        Convert.ToDateTime(dr["data_venda"])
                        );
                    aListVenda.Add(aVenda);
                }

            }
            dr.Close();
            conn.Close();
            return aListVenda;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(int id)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("DELETE FROM Venda WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);

            // Executa Comando
            cmd.ExecuteNonQuery();

        }


    }
}