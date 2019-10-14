﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppCrudsPrj.Modelo
{
    public class Venda
    {
            public int id { get; set; }
            public int pago { get; set; }
            public DateTime data { get; set; }
            public int usuario_id { get; set; }

        public Venda()
            {
                this.id = 0;
                this.pago = 0;
                this.data = DateTime.Now;
                this.usuario_id = 0;
            }

            public Venda(int aid, int apago, DateTime adata, int ausuario_id)
            {
                this.id = aid;
                this.pago = apago;
                this.data = adata;
                this.usuario_id = ausuario_id;
            }
        }
    }
