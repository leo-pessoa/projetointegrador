﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
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

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("INSERT INTO Venda (verif_pago, data_venda, usuario_id)  VALUES(@verif_pago, @data_venda, @usuario_id)", conn);
            cmd.Parameters.AddWithValue("@id", obj.id);
            cmd.Parameters.AddWithValue("@verif_pago", obj.pago);
            cmd.Parameters.AddWithValue("@data_venda", obj.data_venda);
            cmd.Parameters.AddWithValue("@usuario_id", obj.usuario_id);


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
            cmd.CommandText = "SELECT * FROM Venda WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aVenda = new Modelo.Venda(
                        Convert.ToInt32(dr["id"].ToString()),
                         Convert.ToInt32(dr["verif_pago"]),
                        Convert.ToDateTime(dr["data_venda"]).Date,
                        Convert.ToInt32(dr["usuario_id"].ToString())
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
                        Convert.ToInt32(dr["verif_pago"]),
                        Convert.ToDateTime(dr["data_venda"]).Date,
                        Convert.ToInt32(dr["usuario_id"].ToString())
                        );
                    aListVenda.Add(aVenda);
                }

            }
            dr.Close();
            conn.Close();
            return aListVenda;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public string SelectId()
        {
            string id="";
            Modelo.Venda aVenda;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT TOP 1 (id) FROM Venda ORDER BY id DESC";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    id = Convert.ToInt32(dr["id"]).ToString();
                }

            }
            dr.Close();
            conn.Close();
            return id;
        }




        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(Modelo.Venda obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("DELETE FROM Venda WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", obj.id);

            cmd.ExecuteNonQuery();

        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Venda obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("UPDATE Venda SET verif_pago = @verif_pago, data_venda = @data_venda, usuario_id = @usuario_id  WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", obj.id);
            cmd.Parameters.AddWithValue("@verif_pago", obj.pago);
            cmd.Parameters.AddWithValue("@data_venda", obj.data_venda);
            cmd.Parameters.AddWithValue("@usuario_id", obj.usuario_id);
            
            cmd.ExecuteNonQuery();
        }








    }


}