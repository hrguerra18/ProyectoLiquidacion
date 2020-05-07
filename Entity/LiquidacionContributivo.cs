using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class LiquidacionContributivo : Liquidacion
    {
        const double DOSSALARIOS = 1960000;
        const double CINCOSALARIOS = 4900000;
       
        
        public override double CalcularTarifa()
        {
            if (SalarioDevengado < DOSSALARIOS)
            {
                Tarifa = 0.15;
            }
            else if ((SalarioDevengado >= DOSSALARIOS) && (SalarioDevengado <= CINCOSALARIOS))
            {
                Tarifa = 0.20;
            }
            else 
            {
                Tarifa = 0.25;
            }

            return Tarifa;
        }

        public override double CalcularTope()
        {
            if (SalarioDevengado < DOSSALARIOS)
            {
                Tope = 250000;
            }
            else if (SalarioDevengado>= DOSSALARIOS && SalarioDevengado <= CINCOSALARIOS)
            {
                Tope = 900000;
            }
            else
            {
                Tope = 1500000;
            }

            return Tope;
            
        }

      

        
        /*public override double CalcularCuotaModeradora()
        {

            CuotaModeradora = ValorServicio * this.Tarifa;
            if (this.Tarifa == 0.15)
            {
                if (CuotaModeradora < Tope)
                {
                    CuotaModeradora = CuotaModeradora;
                }
                else
                {
                    CuotaModeradora = Tope;
                }
            }
            else if (this.Tarifa == 0.20)
            {
                if (CuotaModeradora < Tope)
                {
                    CuotaModeradora = CuotaModeradora;
                }
                else
                {
                    CuotaModeradora = Tope;
                }
            }
            else if (this.Tarifa == 0.25)
            {
                if (CuotaModeradora < Tope)
                {
                    CuotaModeradora = CuotaModeradora;
                }
                else
                {
                    CuotaModeradora = Tope;
                }
            }

            return CuotaModeradora;
            
        }*/

        
    }
}
