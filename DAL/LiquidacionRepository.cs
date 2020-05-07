using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;

namespace DAL
{
    public class LiquidacionRepository
    {
       
        private string ruta = "liquidacion.Txt";
        IList<Liquidacion> liquidaciones = new List<Liquidacion>();

        public void Guardar(Liquidacion liquidacion)
        {
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(file);
            escritor.WriteLine($"{liquidacion.TipoAfiliacion};{liquidacion.NumeroLiquidacion};{liquidacion.Identificacion};" +
                $"{liquidacion.Fecha.ToShortDateString()};{liquidacion.SalarioDevengado};{liquidacion.ValorServicio};" +
                $"{liquidacion.Tarifa};{liquidacion.CuotaModeradora}");
            escritor.Close();
            file.Close();
            
        }

        public IList<Liquidacion> Consultar()
        {

            liquidaciones.Clear();
            FileStream file = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader escritor = new StreamReader(file);
            string Linea = string.Empty;
            

            while ((Linea = escritor.ReadLine()) != null)
            {
                Liquidacion liquidacion;
                liquidacion = Map(Linea);

                liquidaciones.Add(liquidacion);

            }

            escritor.Close();
            file.Close();

            return liquidaciones;
       
        }

        public Liquidacion Map(string Linea)
        {
            Liquidacion liquidacion;
            char delimiter = ';';
            string[] MatrizLiquidacion = Linea.Split(delimiter);
            if (MatrizLiquidacion[0] == "C")
            {
                liquidacion = new LiquidacionContributivo();
            }
            else 
            {
                liquidacion = new LiquidacionSubsidiado();
            }
            liquidacion.TipoAfiliacion = MatrizLiquidacion[0];
            liquidacion.NumeroLiquidacion = MatrizLiquidacion[1];
            liquidacion.Identificacion = MatrizLiquidacion[2];
            liquidacion.Fecha = Convert.ToDateTime(MatrizLiquidacion[3]);
            liquidacion.SalarioDevengado = Convert.ToInt32(MatrizLiquidacion[4]);
            liquidacion.ValorServicio = Convert.ToInt32(MatrizLiquidacion[5]);
            liquidacion.Tarifa = Convert.ToDouble(MatrizLiquidacion[6]);
            liquidacion.CuotaModeradora = Convert.ToDouble(MatrizLiquidacion[7]);

            return liquidacion;
        }

        public void Modificar(string NumeroLiqudacion, Liquidacion LiquidacionNueva)
        {
            liquidaciones.Clear();
            liquidaciones = Consultar();
            FileStream file = new FileStream(ruta, FileMode.Create);
            file.Close();

            foreach (var item in liquidaciones)
            {
                if (NumeroLiqudacion.Equals(item.NumeroLiquidacion))
                {
                    Guardar(LiquidacionNueva);
                }
                else
                {
                    Guardar(item);
                }
            }
        }

        public void Eliminar(string NumeroLiquidacion)
        {
            liquidaciones.Clear();
             liquidaciones = Consultar();
            FileStream file = new FileStream(ruta, FileMode.Create);
            file.Close();

            foreach (var item in liquidaciones)
            {
                if (NumeroLiquidacion != item.NumeroLiquidacion)
                {
                    Guardar(item);
                }
            }

        }

        public Liquidacion Buscar(string NumeroLiquidacion)
        {

            liquidaciones = Consultar();
            return liquidaciones.Where(l => l.NumeroLiquidacion == NumeroLiquidacion).FirstOrDefault();
            
        }

        public int TotalLiquidaciones()
        {
            liquidaciones = Consultar();
            return liquidaciones.Count();
        }

        public int TotalLiquidacionesTipo(string tipo)
        {
            liquidaciones = Consultar();
            return liquidaciones.Count(l => l.TipoAfiliacion.Equals(tipo));
        }

        public IList<Liquidacion> ListarTipo(string tipo)
        {
            liquidaciones = Consultar();
            return liquidaciones.Where(l => l.TipoAfiliacion.Equals(tipo)).ToList();
        }
        public double TotalCuotaModeradora()
        {
            liquidaciones = Consultar();
            return liquidaciones.Sum(l => l.CuotaModeradora);
        }
        public double TotalCuotaModeradoraTipo(string tipo)
        {
            liquidaciones = Consultar();
            return liquidaciones.Where(l => l.TipoAfiliacion.Equals(tipo)).Sum(l => l.CuotaModeradora);
        }
        public IList <Liquidacion> FiltroFecha(DateTime mes, DateTime año)
        {
            liquidaciones = Consultar();
            return liquidaciones.Where(l => l.Fecha.Month.Equals(mes.Month) & l.Fecha.Year.Equals(año.Year)).ToList();
        }
        public int TotalLiquidaciones(IList<Liquidacion> liquidaciones)
        {
            
            return liquidaciones.Count();
        }
        public int TotalLiquidacionesTipo(string tipo, IList<Liquidacion> liquidaciones)
        {
            
            return liquidaciones.Count(l => l.TipoAfiliacion.Equals(tipo));
        }
        public double TotalCuotaModeradora(IList<Liquidacion> liquidaciones)
        {
            
            return liquidaciones.Sum(l => l.CuotaModeradora);
        }
        public double TotalCuotaModeradoraTipo(string tipo, IList<Liquidacion> liquidaciones)
        {
            
            return liquidaciones.Where(l => l.TipoAfiliacion.Equals(tipo)).Sum(l => l.CuotaModeradora);
        }
        public IList<Liquidacion> BuscarContiene(string NumeroLiquidacion)
        {
            liquidaciones = Consultar();
            return liquidaciones.Where(l => l.NumeroLiquidacion.Contains(NumeroLiquidacion)).ToList();
        }
    }

        
}
