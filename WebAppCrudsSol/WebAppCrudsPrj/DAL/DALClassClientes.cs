using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAppCrudsPrj.DAL
{
    public class DALClassClientes
    {
        string connectionString = "";

        public DALClassClientes()
        {
            connectionString = ConfigurationManager.ConnectionStrings["SGEDConnectionString"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]

        public List<Modelo.Clientes> SelectAll()
        {
            Modelo.Clientes aClientes;
            List<Modelo.Clientes> aListClientes = new List<Modelo.Clientes>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Usuario WHERE perfil = 'cliente' ";
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

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(Modelo.Clientes obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("DELETE FROM Usuario WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", obj.id);

            cmd.ExecuteNonQuery();

        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Clientes obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("INSERT INTO Usuario (nome, cpf, perfil) VALUES(@nome, @cpf, @perfil)", conn);
            cmd.Parameters.AddWithValue("@nome", obj.nome);
            cmd.Parameters.AddWithValue("@cpf", obj.cpf);
            cmd.Parameters.AddWithValue("@perfil", obj.perfil);
            
            cmd.ExecuteNonQuery();

        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Clientes obj)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            SqlCommand cmd = new SqlCommand("UPDATE Usuario SET nome = @nome, cpf = @cpf, perfil = @perfil WHERE id = @id", conn);;
            cmd.Parameters.AddWithValue("@nome", obj.nome);
            cmd.Parameters.AddWithValue("@cpf", obj.cpf);
            cmd.Parameters.AddWithValue("@perfil", obj.perfil);
            
            cmd.ExecuteNonQuery();
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Clientes> Select(int id)
        {
            Modelo.Clientes aClientes;
            List<Modelo.Clientes> aListClientes = new List<Modelo.Clientes>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Usuario WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
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

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Clientes> Select(String nome)
        {
            Modelo.Clientes aClientes;
            List<Modelo.Clientes> aListClientes = new List<Modelo.Clientes>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Usuario WHERE nome like '%"+nome+"%' and perfil = 'cliente' ";
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