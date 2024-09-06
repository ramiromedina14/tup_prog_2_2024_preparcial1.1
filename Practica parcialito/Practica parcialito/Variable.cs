using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_parcialito
{
    public class Variable:Costo
    {
        private double precioPorUnidad = 0;
        private double unidades = 0;
        public double PrecioPorUnidad { get { return precioPorUnidad; } }
        public override double ValorFinal { get { return precioPorUnidad * unidades; } }

        public Variable (string concepto, double unidades, double precioPorUnidad): base(concepto)
        {
            this.unidades = unidades;
            this.precioPorUnidad = precioPorUnidad;

        }
        public override string VerDetalle()
        {
            return "mal, gorda puta";
        }

    }
}
