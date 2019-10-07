using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppCrudsPrj.Modelo
{
    public class Usuarios
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string log_in { get; set; }
        public string senha { get; set; }
        public string perfil { get; set; }

        public Usuarios()
        {
            this.id = 0;
            this.nome = "";
            this.log_in = "";
            this.senha = "";
            this.perfil = "";
        }

        public Usuarios( int aid, string anome, string alog_in, string asenha, string aperfil)
        {
            this.id = aid;
            this.nome = anome;
            this.log_in = alog_in;
            this.senha = asenha;
            this.perfil = aperfil;
        }
    }
}