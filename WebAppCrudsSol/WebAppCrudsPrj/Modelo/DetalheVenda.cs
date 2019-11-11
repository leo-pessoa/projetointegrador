using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppCrudsPrj.Modelo
{
    public class DetalheVenda
    {
            public int venda_id { get; set; }
            public int produto_id { get; set; }
            public int quantidadeprod { get; set; }
            public Modelo.Produtos produto { get; set; }

            public DetalheVenda()
            {
                this.venda_id = 0;
                this.produto_id = 0;
                this.quantidadeprod = 0;
            }

            public DetalheVenda(int avenda_id, int aproduto_id, int aqtd_prod)
            {
                this.venda_id = avenda_id;
                this.produto_id = aproduto_id;
                this.quantidadeprod = aqtd_prod;
            }
        }


  
}