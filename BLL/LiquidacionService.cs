using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class LiquidacionService
    {
        private LiquidacionRepository liquidacionRepository;

        public LiquidacionService()
        {
            liquidacionRepository = new LiquidacionRepository();
        }

        public string Guardar(Liquidacion liquidacion)
        {
            if (liquidacionRepository.Buscar(liquidacion.NumeroLiquidacion) == null)
            {
                liquidacionRepository.Guardar(liquidacion);
                return "La liquidacion se ha guardado satisfactoriamente";
            }
            return "Esa liquidacion ya se encuentra registrada";

        }

        public RespuestaConsultar Consultar()
        {
            RespuestaConsultar respuesta = new RespuestaConsultar();
            
            try
            {
                respuesta.liquidaciones = liquidacionRepository.Consultar();
                respuesta.Mensaje = "Se ha consultado correctamente";
                return respuesta;
            }
            catch (Exception e)
            {

                respuesta.Mensaje = "Error en el archivo" + e.Message;
                return respuesta;
            }
            
        }

        public string Modificar(string NumeroLiquidacion, Liquidacion LiquidacionNueva)
        {
            if (liquidacionRepository.Buscar(NumeroLiquidacion) != null)
            {
                liquidacionRepository.Modificar(NumeroLiquidacion, LiquidacionNueva);
                return $"La liquidacion se ha modificado correctamente ";
            }


            return $"La liquidacion {NumeroLiquidacion} no se encuentra registrada";


        }

        public string Eliminar(string NumeroLiquidacion)
        {
            if (liquidacionRepository.Buscar(NumeroLiquidacion) != null)
            {
                liquidacionRepository.Eliminar(NumeroLiquidacion);
                return $"La liquidacion se ha eliminado correctamente";
            }


            return $"La liquidacion con numero {NumeroLiquidacion} no se encuentra registrada";

        }

        public RespuestaTotalLiquidaciones TotalLiquidaciones()
        {
            RespuestaTotalLiquidaciones respuesta = new RespuestaTotalLiquidaciones();
            try
            {
                respuesta.Liquidacion = liquidacionRepository.TotalLiquidaciones();
                if (respuesta.Liquidacion == 0)
                {
                    respuesta.Mensaje = "No hay datos a consultar";
                }
                else
                {
                    respuesta.Mensaje = "Se ha calculado correctamente";
                }
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = "Error en el archivo" + e.Message;
                return respuesta;
                
            }
            
        }

        public RespuestaTotalLiquidaciones TotalLiquidacionesTipo(string tipo)
        {
            RespuestaTotalLiquidaciones respuesta = new RespuestaTotalLiquidaciones();
            try
            {
                respuesta.Liquidacion = liquidacionRepository.TotalLiquidacionesTipo(tipo);
                respuesta.Mensaje = "Se ha contado correctamente";
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = "Error en el archivo" + e.Message;
                return respuesta;
            }
            
        }

        public RespuestaListarTipo ListarTipo(string tipo)
        {
            RespuestaListarTipo respuesta = new RespuestaListarTipo();
            try
            {
                respuesta.liquidaciones = liquidacionRepository.ListarTipo(tipo);
                if (respuesta.liquidaciones.Count == 0)
                {
                    respuesta.Mensaje = "No hay datos en la lista";
                }
                else
                {
                    respuesta.Mensaje = "Se ha consultado correctamente";
                }
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = "Error en el archivo" + e.Message;
                return respuesta;
               
            }
        }
        public double TotalCuotaModeradora()
        {
            return liquidacionRepository.TotalCuotaModeradora();
        }
        public double TotalCuotaModeradoraTipo(string tipo) 
        {
            return liquidacionRepository.TotalCuotaModeradoraTipo(tipo);
        }
        public IList<Liquidacion> FiltroFecha(DateTime mes, DateTime año)
        {
            return liquidacionRepository.FiltroFecha(mes,año);
        }

        public int Contar(IList<Liquidacion> liquidaciones)
        {
           return liquidaciones.Count();

        }
        public int TotalLiquidaciones(IList<Liquidacion> liquidaciones)
        {

            return liquidacionRepository.TotalLiquidaciones(liquidaciones);
        }
        public int TotalLiquidacionesTipo(string tipo, IList<Liquidacion> liquidaciones)
        {

            return liquidacionRepository.TotalLiquidacionesTipo(tipo, liquidaciones);
        }
        public double TotalCuotaModeradora(IList<Liquidacion> liquidaciones)
        {

            return liquidacionRepository.TotalCuotaModeradora(liquidaciones);
        }
        public double TotalCuotaModeradoraTipo(string tipo, IList<Liquidacion> liquidaciones)
        {

            return liquidacionRepository.TotalCuotaModeradoraTipo(tipo, liquidaciones);
        }
        public IList<Liquidacion> BuscarContiene(string NumeroLiquidacion)
        {
            return liquidacionRepository.BuscarContiene(NumeroLiquidacion);
        }
    }

    public class RespuestaConsultar
    {
        public IList<Liquidacion> liquidaciones { get; set; }
        public string Mensaje { get; set; }
    }
    public class RespuestaListarTipo
    {
        public IList<Liquidacion> liquidaciones { get; set; }
        public string Mensaje { get; set; }
    }
    public class RespuestaTotalLiquidaciones
    {
        public int Liquidacion { get; set; }
        public string Mensaje { get; set; }
    }
}
