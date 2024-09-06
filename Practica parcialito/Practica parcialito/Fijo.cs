using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_parcialito
{
   public class Fijo:Costo
    {
      public Fijo(string concepto, double valorFinal) : base(concepto)
      {
            this.ValorFinal = valorFinal;
      }
        public override string VerDetalle()
        {
            return $"{Concepto:20}";
        }

    }
}
