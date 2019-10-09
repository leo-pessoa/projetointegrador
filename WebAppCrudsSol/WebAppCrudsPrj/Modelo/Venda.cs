using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppCrudsPrj.Modelo
{
    public class Venda
    {
            public int id { get; set; }
            public string pago { get; set; }
            public DateTime data { get; set; }
            public int usuario_id { get; set; }

        public Venda()
            {
                this.id = 0;
                this.pago = "";
                this.data = Convert.ToDateTime("");
                this.usuario_id = 0;
            }

            public Venda(int aid, string apago, DateTime adata, int ausuario_id)
            {
                this.id = aid;
                this.pago = apago;
                this.data = adata;
                this.usuario_id = ausuario_id;
            }
        }
    }
