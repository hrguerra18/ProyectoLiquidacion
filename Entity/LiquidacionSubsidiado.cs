using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class LiquidacionSubsidiado : Liquidacion
    {
        
        public override double CalcularTarifa()
        {
            Tarifa = 0.05;
            return Tarifa;
        }

        public override double CalcularTope()
        {
            Tope = 200000;

            return Tope;
        }

       /* public override double CalcularCuotaModeradora()
        {
            CuotaModeradora = ValorServicio * this.Tarifa;
            if (CuotaModeradora > Tope)
            {

                CuotaModeradora = Tope;

            }
            else if (CuotaModeradora < Tope)
            {
                CuotaModeradora = CuotaModeradora;
            }

            return CuotaModeradora;
        }*/

       
    }
}
