using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAppCruds.DAL
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
            cmd.CommandText = "SELECT * FROM Usuario WHERE perfil = 'cliente' ";
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

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public void Delete(Modelo.Clientes obj)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("DELETE FROM Usuario WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", obj.id);

            // Executa Comando
            cmd.ExecuteNonQuery();

        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public void Insert(Modelo.Clientes obj)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("INSERT INTO Usuario (id, nome, cpf, perfil) VALUES(@id, @nome, @cpf, @perfil)", conn);
            cmd.Parameters.AddWithValue("@id", obj.id);
            cmd.Parameters.AddWithValue("@nome", obj.nome);
            cmd.Parameters.AddWithValue("@cpf", obj.cpf);
            cmd.Parameters.AddWithValue("@perfil", obj.perfil);

            // Executa Comando
            cmd.ExecuteNonQuery();

        }

        [DataObjectMethod(DataObjectMethodType.Update)]
        public void Update(Modelo.Clientes obj)
        {
            // Cria Conexão com banco de dados
            SqlConnection conn = new SqlConnection(connectionString);
            // Abre conexão com o banco de dados
            conn.Open();
            // Cria comando SQL
            SqlCommand com = conn.CreateCommand();
            // Define comando de exclusão
            SqlCommand cmd = new SqlCommand("UPDATE Usuario SET id = @id, nome = @nome, cpf = @cpf, perfil = @perfil WHERE id = @id", conn);
            cmd.Parameters.AddWithValue("@id", obj.id);
            cmd.Parameters.AddWithValue("@nome", obj.nome);
            cmd.Parameters.AddWithValue("@cpf", obj.cpf);
            cmd.Parameters.AddWithValue("@perfil", obj.perfil);

            // Executa Comando
            cmd.ExecuteNonQuery();
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Clientes> Select(int id)
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
            cmd.CommandText = "SELECT * FROM Usuario WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);
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

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Clientes> Select(String nome)
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
            cmd.CommandText = "SELECT * FROM Usuario WHERE nome like '%"+nome+"%' and perfil = 'cliente' ";
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

        //[DataObjectMethod(DataObjectMethodType.Select)]
        //public List<Modelo.Clientes> Select2(String cpf)
        //{
        //    // Variavel para armazenar um livro
        //    Modelo.Clientes aClientes;
        //    // Cria Lista Vazia
        //    List<Modelo.Clientes> aListClientes = new List<Modelo.Clientes>();
        //    // Cria Conexão com banco de dados
        //    SqlConnection conn = new SqlConnection(connectionString);
        //    // Abre conexão com o banco de dados
        //    conn.Open();
        //    // Cria comando SQL
        //    SqlCommand cmd = conn.CreateCommand();
        //    // define SQL do comando
        //    cmd.CommandText = "SELECT * FROM Usuario WHERE cpf = @cpf AND perfil = 'cliente'";
        //    cmd.Parameters.AddWithValue("@cpf", cpf);

        //    // Executa comando, gerando objeto DbDataReader
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    // Le titulo do livro do resultado e apresenta no segundo rótulo
        //    if (dr.HasRows)
        //    {
        //        while (dr.Read()) // Le o proximo registro
        //        {
        //            // Cria objeto com dados lidos do banco de dados
        //            aClientes = new Modelo.Clientes(
        //                Convert.ToInt32(dr["id"].ToString()),
        //                dr["nome"].ToString(),
        //                dr["cpf"].ToString(),
        //                dr["perfil"].ToString()
        //                );
        //            // Adiciona o livro lido à lista
        //            aListClientes.Add(aClientes);
        //        }
        //    }
        //    // Fecha DataReader
        //    dr.Close();
        //    // Fecha Conexão
        //    conn.Close();

        //    return aListClientes;
        //}



    }
}