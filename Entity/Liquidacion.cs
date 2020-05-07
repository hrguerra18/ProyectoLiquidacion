using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public abstract class Liquidacion
    {
        public string NumeroLiquidacion { get; set; }
        public string Identificacion { get; set; }
        public string TipoAfiliacion { get; set; }
        public DateTime Fecha { get; set; }
        public double SalarioDevengado { get; set; }
        public double ValorServicio { get; set; }
        public double Tarifa { get; set; }
        public double CuotaModeradora { get; set; }
        double CuotaModeradoraReal;
        public double Tope { get; set; }
        public IList<Liquidacion> liquidaciones { get; set; }

        public abstract double CalcularTarifa();

        public abstract double CalcularTope();
        public  double CalcularCuotaModeradora()
        {
            
            Tarifa = CalcularTarifa();
            CuotaModeradoraReal = ValorServicio * this.Tarifa;
            ValidarTope();

            return CuotaModeradora;
        }

        public double ValidarTope()
        {
            Tope = CalcularTope();

            if (CuotaModeradoraReal > this.Tope)
            {
                CuotaModeradora = Tope;
            }
            else
            {
                CuotaModeradora = CuotaModeradoraReal;
            }

            return CuotaModeradora;

        }



    }
}
