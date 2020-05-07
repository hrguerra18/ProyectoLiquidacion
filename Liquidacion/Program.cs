using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using BLL;
namespace LiquidacionUI

{
    class Program
    {
        static void Main(string[] args)
        {
            List<Liquidacion> liquidaciones = new List<Liquidacion>();
            Liquidacion liquidacionContributivo = new LiquidacionContributivo();
            Liquidacion liquidacionSubsidiado = new LiquidacionSubsidiado();
            LiquidacionService liquidacionService = new LiquidacionService();
            
            int Opcion = 0;
            char Tipo;
            int NumeroLiquidacion;

            do
            {
                
                Console.WriteLine("============== MENU ===============");
                Console.WriteLine("1. Guardar");
                Console.WriteLine("2. Consultar");
                Console.WriteLine("3. Modificar");
                Console.WriteLine("4. Eliminar");
                Console.WriteLine("5. Salir");


                Console.WriteLine("\n Que opcion deseas hacer.... ");
                Opcion = Convert.ToInt32(Console.ReadLine());
                

                switch (Opcion)
                {
                    
                    case 1 :
                        Console.Clear();
                        Console.WriteLine("======== DATOS A REGISTRAR ========");
                        Console.WriteLine("Digite su tipo de afiliacion  Contributivo -> C     Subsidiado -> S: ");
                        Tipo = Convert.ToChar(Console.ReadLine());
                        
                        if (Tipo == 's')
                        {
                            liquidacionSubsidiado.TipoAfiliacion = Convert.ToString(Tipo);
                            Console.WriteLine("Digite su numero de liquidacion: ");
                            liquidacionSubsidiado.NumeroLiquidacion = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite su identificacion: ");
                            liquidacionSubsidiado.Identificacion = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite su salario: ");
                            liquidacionSubsidiado.SalarioDevengado = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Digite valor del servicio: ");
                            liquidacionSubsidiado.ValorServicio = Convert.ToDouble(Console.ReadLine());

                            liquidacionSubsidiado.CalcularTarifa();
                            liquidacionSubsidiado.CalcularTope();
                            liquidacionSubsidiado.CalcularCuotaModeradora();
                            Console.WriteLine($"la cuota a pagar es de {liquidacionSubsidiado.CalcularCuotaModeradora()}");
                            liquidacionService.Guardar(liquidacionSubsidiado);
                            
                        }
                        else if (Tipo == 'c')
                        {
                            liquidacionContributivo.TipoAfiliacion = Convert.ToString(Tipo);
                            Console.WriteLine("Digite su numero de liquidacion: ");
                            liquidacionContributivo.NumeroLiquidacion = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite su identificacion: ");
                            liquidacionContributivo.Identificacion = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite su salario: ");
                            liquidacionContributivo.SalarioDevengado = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Digite valor del servicio: ");
                            liquidacionContributivo.ValorServicio = Convert.ToDouble(Console.ReadLine());

                            liquidacionContributivo.CalcularTarifa();
                            liquidacionContributivo.CalcularTope();
                            liquidacionContributivo.CalcularCuotaModeradora();
                            Console.WriteLine($"la cuota a pagar es de {liquidacionContributivo.CalcularCuotaModeradora()}");
                            liquidacionService.Guardar(liquidacionContributivo);
                        }

                        break;
                    case 2:
                        Console.Clear();
                        liquidaciones = liquidacionService.Consultar();
                        foreach (var item in liquidaciones)
                        {
                            Console.WriteLine($"Tipo Regimen: {item.TipoAfiliacion} -- Numero liquidacion: {item.NumeroLiquidacion}" +
                                $"-- Identificacion: {item.Identificacion} -- Salario: {item.SalarioDevengado} -- " +
                                $"Valor del servicio: {item.ValorServicio} -- Tarifa: {item.Tarifa} -- Cuota Moderadora: {item.CuotaModeradora}");

                            Console.WriteLine(" ");
                        }

                        break;

                    case 3:
                        Console.Clear();

                        Console.WriteLine("================= LIQUIDACION A MODIFICAR =================");
                        Console.WriteLine(" ");
                        Console.WriteLine("Ingrese el numero de liquidacion que desea modificar");
                        NumeroLiquidacion = Convert.ToInt32(Console.ReadLine());
                        
                        Console.WriteLine("\nDigite su tipo de afiliacion  Contributivo -> C     Subsidiado -> S: ");
                        Tipo = Convert.ToChar(Console.ReadLine());
                        if (Tipo == 's')
                        {
                            Liquidacion LiquidacionNueva = new LiquidacionSubsidiado();
                            liquidacionSubsidiado.TipoAfiliacion = Convert.ToString(Tipo);
                            Console.WriteLine("Digite su identificacion: ");
                            liquidacionSubsidiado.Identificacion = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite su salario: ");
                            liquidacionSubsidiado.SalarioDevengado = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Digite valor del servicio: ");
                            liquidacionSubsidiado.ValorServicio = Convert.ToDouble(Console.ReadLine());

                            liquidacionSubsidiado.CalcularTarifa();
                            liquidacionSubsidiado.CalcularTope();
                            liquidacionSubsidiado.CalcularCuotaModeradora();

                            LiquidacionNueva.TipoAfiliacion = liquidacionSubsidiado.TipoAfiliacion;
                            LiquidacionNueva.NumeroLiquidacion = NumeroLiquidacion;
                            LiquidacionNueva.Identificacion = liquidacionSubsidiado.Identificacion;
                            LiquidacionNueva.SalarioDevengado = liquidacionSubsidiado.SalarioDevengado;
                            LiquidacionNueva.ValorServicio = liquidacionSubsidiado.ValorServicio;
                            LiquidacionNueva.Tarifa = liquidacionSubsidiado.CalcularTarifa();
                            LiquidacionNueva.CuotaModeradora = liquidacionSubsidiado.CalcularCuotaModeradora();

                            liquidacionService.Modificar(NumeroLiquidacion, LiquidacionNueva);

                        }
                        else if (Tipo == 'c')
                        {
                            Liquidacion LiquidacionNueva = new LiquidacionContributivo();
                            liquidacionContributivo.TipoAfiliacion = Tipo.ToString();
                            Console.WriteLine("Digite su identificacion: ");
                            liquidacionContributivo.Identificacion = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite su salario: ");
                            liquidacionContributivo.SalarioDevengado = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Digite valor del servicio: ");
                            liquidacionContributivo.ValorServicio = Convert.ToDouble(Console.ReadLine());

                            liquidacionContributivo.CalcularTarifa();
                            liquidacionContributivo.CalcularTope();
                            liquidacionContributivo.CalcularCuotaModeradora();

                            LiquidacionNueva.TipoAfiliacion = liquidacionContributivo.TipoAfiliacion;
                            LiquidacionNueva.NumeroLiquidacion = NumeroLiquidacion;
                            LiquidacionNueva.Identificacion = liquidacionContributivo.Identificacion;
                            LiquidacionNueva.SalarioDevengado = liquidacionContributivo.SalarioDevengado;
                            LiquidacionNueva.ValorServicio = liquidacionContributivo.ValorServicio;
                            LiquidacionNueva.Tarifa = liquidacionContributivo.CalcularTarifa();
                            LiquidacionNueva.CuotaModeradora = liquidacionContributivo.CalcularCuotaModeradora();

                            liquidacionService.Modificar(NumeroLiquidacion, LiquidacionNueva);
                        }
                        
                        break;


                    case 4:
                        Console.Clear();
                        Console.WriteLine("================= LIQUIDACION A ELIMINAR =================");
                        Console.WriteLine(" ");
                        Console.WriteLine("Ingrese el numero de liquidacion que desea eliminar: ");
                        NumeroLiquidacion = Convert.ToInt32(Console.ReadLine());
                        string respuesta = liquidacionService.Eliminar(NumeroLiquidacion);

                        Console.WriteLine(respuesta);
                        break;

                    case 5:
                        Console.WriteLine($"Gracias por usar el programa...");
                        Console.ReadKey();

                        break;

                    default:

                        Console.WriteLine($"ESA OPCION {Opcion} NO ES VALIDA....");
                        Console.Clear();
                        break;
                }




            } while (Opcion != 5);


            Console.ReadKey();
        }
    }
}
