using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppCrudsPrj.Modelo
{
    public class Fornecedores
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }

        public Fornecedores()
        {
            this.id = 0;
            this.nome = "";
            this.email = "";
            this.telefone = "";
        }

        public Fornecedores(int aid, string anome, string aemail, string atelefone)
        {
            this.id = aid;
            this.nome = anome;
            this.email = aemail;
            this.telefone = atelefone;
        }
    }
}