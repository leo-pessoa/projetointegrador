using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppCruds.Modelo
{
    public class Clientes
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string perfil { get; set; }

        public Clientes(){
            this.id = 0;
            this.nome = "";
            this.cpf = "";
            this.perfil = "cliente";
        }

        public Clientes(int aid, string anome, string acpf, string aperfil)
        {
            this.id = aid;
            this.nome = anome;
            this.cpf = acpf;
            this.perfil = aperfil;
        }
    }
}