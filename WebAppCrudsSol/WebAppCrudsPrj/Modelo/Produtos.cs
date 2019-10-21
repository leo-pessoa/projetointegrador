using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppCrudsPrj.Modelo
{
    public class Produtos
    {
        public int id { get; set; }
        public string nome { get; set; }
        public double valor { get; set; }
        public string descricao { get; set; }
        public int quantidade { get; set; }
        public int fornecedor_id { get; set; }

        public Produtos()
        {
            this.id = 0;
            this.nome = "";
            this.valor = 0d;
            this.descricao = "";
            this.quantidade = 0;
            this.fornecedor_id = 0;
        }

        public Produtos(int aid, string anome, double avalor, string adescricao, int aquantidade, int afornecedor_id)
        {
            this.id = aid;
            this.nome = anome;
            this.valor = avalor;
            this.descricao = adescricao;
            this.quantidade = aquantidade;
            this.fornecedor_id = afornecedor_id;
        }
    }
}