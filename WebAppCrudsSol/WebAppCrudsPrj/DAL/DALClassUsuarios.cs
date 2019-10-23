using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAppCrudsPrj.DAL
{
    public class DALClassUsuarios
    {
        string connectionString = "";

        public DALClassUsuarios()
        {
            connectionString = ConfigurationManager.ConnectionStrings["SGEDConnectionString"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Usuarios obj)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("INSERT INTO Usuario (nome, log_in, senha, perfil) VALUES(@nome, @log_in, @senha, @perfil)", conn);
            cmd.Parameters.AddWithValue("@nome", obj.nome);
            cmd.Parameters.AddWithValue("@log_in", obj.log_in);
            cmd.Parameters.AddWithValue("@senha", obj.senha);
            cmd.Parameters.AddWithValue("@perfil", obj.perfil);

            // Executa Comando
            cmd.ExecuteNonQuery();

        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Usuarios> Select(string log_in)
        {
           
            Modelo.Usuarios aUsuarios;
            List<Modelo.Usuarios> aListUsuarios = new List<Modelo.Usuarios>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Usuario WHERE log_in = @log_in";
            cmd.Parameters.AddWithValue("@log_in", log_in);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read()) 
                {
                    aUsuarios = new Modelo.Usuarios(
                        Convert.ToInt32(dr["id"].ToString()),
                        dr["nome"].ToString(),
                        dr["log_in"].ToString(),
                        dr["senha"].ToString(),
                        dr["perfil"].ToString()
                        );
                    aListUsuarios.Add(aUsuarios);
                }

            }
            dr.Close();
            conn.Close();
            return aListUsuarios;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Usuarios> SelectAll()
        {

            Modelo.Usuarios aUsuarios;
            List<Modelo.Usuarios> aListUsuarios = new List<Modelo.Usuarios>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM Usuario WHERE perfil = 'sistema'";
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aUsuarios = new Modelo.Usuarios(
                        Convert.ToInt32(dr["id"].ToString()),
                        dr["nome"].ToString(),
                        dr["log_in"].ToString(),
                        dr["senha"].ToString(),
                        dr["perfil"].ToString()
                        );
                    aListUsuarios.Add(aUsuarios);
                }

            }
            dr.Close();
            conn.Close();
            return aListUsuarios;
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
            SqlCommand cmd = new SqlCommand("DELETE FROM Usuario WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);

            // Executa Comando
            cmd.ExecuteNonQuery();

        }
    }
}