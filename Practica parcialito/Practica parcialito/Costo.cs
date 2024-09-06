using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_parcialito
{
    public abstract class Costo
    {
        private string concepto;
        private double valorFinal = 0;
        public string Concepto { get { return concepto; } }
        public virtual double ValorFinal { get { return valorFinal; } }

        public Costo(string concepto)
        {
            this.concepto = concepto;
        }

        public abstract string VerDetalle();
        
    }
}
