﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebAppCrudsPrj.DAL
{
    public class DALClassConsultas
    {
        private string connectionString = "";

        public DALClassConsultas()
        {
            connectionString = ConfigurationManager.ConnectionStrings ["SGEDConnectionString"].ConnectionString;
        }

        public DataSet SelectDividas(String cpf)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = ("SELECT  dv.venda_id AS Código, p.nome AS Produto, dv.quantidadeprod AS Quantidade, SUM(p.valor*dv.quantidadeprod) AS Valor, CONVERT(VARCHAR(10), v.data_venda , 103) AS [Data]  FROM Detalhe_Venda dv INNER JOIN Venda v ON v.id = dv.venda_id INNER JOIN Produtos p ON p.id = dv.produto_id INNER JOIN Usuario us ON v.usuario_id = us.id WHERE us.cpf = '" + cpf + "' AND v.verif_pago = 0 GROUP BY dv.produto_id, dv.venda_id, p.nome, dv.quantidadeprod, v.data_venda ORDER BY v.data_venda ASC");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds;
        }

        public DataSet SelectDetalhe(int id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = ("SELECT	dv.produto_id AS Código, p.nome AS Produto, dv.quantidadeprod AS Quantidade, SUM(p.valor * dv.quantidadeprod) AS Valor FROM Detalhe_Venda dv INNER JOIN Venda v ON v.id = dv.venda_id INNER JOIN Produtos p ON p.id = dv.produto_id WHERE dv.venda_id = "+id+" GROUP BY dv.produto_id, p.nome, dv.quantidadeprod");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds;
        }

        public DataSet SelectDetalhe2(int id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = ("SELECT	dv.produto_id AS Código, p.nome AS Produto, dv.quantidadeprod AS Quantidade, p.valor AS Valor_Unitário, SUM(p.valor * dv.quantidadeprod) AS Valor_Total  FROM Detalhe_Venda dv INNER JOIN Venda v ON v.id = dv.venda_id INNER JOIN Produtos p ON p.id = dv.produto_id WHERE dv.venda_id = " + id + " GROUP BY dv.produto_id, p.nome, dv.quantidadeprod, p.valor");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds;
        }

        public DataSet SelectVtotal(int id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = ("SELECT	SUM(p.valor*dv.quantidadeprod) AS Subtotal FROM Detalhe_Venda dv INNER JOIN Venda v ON v.id = dv.venda_id INNER JOIN Produtos p ON p.id = dv.produto_id  WHERE dv.venda_id = "+id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds;
        }

        public DataSet SelectLogin(String login)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = ("SELECT  nome FROM Usuario WHERE log_in = '"+login+"'");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds;
        }

        public void UpdateDivida(int id)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = ("UPDATE Venda SET verif_pago = 1 WHERE id = "+id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }

        public DataSet SelectProdutosDisp()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = ("SELECT p.nome AS Nome, p.descricao AS Descrição, p.valor AS Valor, p.quantidade AS Quantidade  FROM Produtos p  WHERE p.quantidade != 0 ORDER BY p.nome ASC");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return ds;
        }

        public void UpdateDVenda(int vendaid, int produtoid, int quantidadeprod)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = ("UPDATE Detalhe_Venda SET quantidadeprod = "+quantidadeprod+" WHERE venda_id = " + vendaid + " AND produto_id = " + produtoid);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }
    }
}