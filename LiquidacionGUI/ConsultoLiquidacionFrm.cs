using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace LiquidacionGUI
{
    public partial class ConsultoLiquidacionFrm : Form
    {
        LiquidacionService liquidacionService = new LiquidacionService();
        public ConsultoLiquidacionFrm()
        {
            InitializeComponent();
            
        }

        private void LlenarTabla()
        {
            Tabla.DataSource = null;

            Tabla.DataSource = liquidacionService.Consultar();
        }

        private void Tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (CmbFiltrarTipo.Text == "Todos")
            {
                Tabla.DataSource = null;

                RespuestaConsultar respuesta = new RespuestaConsultar();
                RespuestaTotalLiquidaciones total = new RespuestaTotalLiquidaciones();
                RespuestaTotalLiquidaciones totalTipoC = new RespuestaTotalLiquidaciones();
                RespuestaTotalLiquidaciones totalTipoS = new RespuestaTotalLiquidaciones();
                respuesta = liquidacionService.Consultar();
                MessageBox.Show(respuesta.Mensaje);
                Tabla.DataSource = respuesta.liquidaciones;
                total = liquidacionService.TotalLiquidaciones();
                TxtTotalLiquidaciones.Text = total.Liquidacion.ToString();
                totalTipoC = liquidacionService.TotalLiquidacionesTipo("C");
                TxtLiquidacionesContributivo.Text = totalTipoC.Liquidacion.ToString();
                totalTipoS = liquidacionService.TotalLiquidacionesTipo("S");
                TxtLiquidacionesSubsidiado.Text = totalTipoS.Liquidacion.ToString();
                TxtTotalCuotaModeradora.Text = liquidacionService.TotalCuotaModeradora().ToString();
                TxtTotalCuotaModeradoraContributivo.Text = " ";
                TxtTotalCuotaModeradoraSubsidiado.Text = " ";
            }
            else if (CmbFiltrarTipo.Text == "C")
            {
                Tabla.DataSource = null;
                RespuestaListarTipo respuesta = new RespuestaListarTipo();
                RespuestaTotalLiquidaciones total = new RespuestaTotalLiquidaciones();
                respuesta = liquidacionService.ListarTipo("C");
                MessageBox.Show(respuesta.Mensaje);
                Tabla.DataSource = respuesta.liquidaciones;
                TxtTotalLiquidaciones.Text = " ";
                total = liquidacionService.TotalLiquidacionesTipo("C");
                TxtLiquidacionesContributivo.Text = total.Liquidacion.ToString();
                TxtLiquidacionesSubsidiado.Text = " ";
                TxtTotalCuotaModeradoraContributivo.Text = liquidacionService.TotalCuotaModeradoraTipo("C").ToString();
                TxtTotalCuotaModeradora.Text = " ";
                TxtTotalCuotaModeradoraSubsidiado.Text = " ";
            }
            else if (CmbFiltrarTipo.Text == "S")
            {
                Tabla.DataSource = null;
                RespuestaListarTipo respuesta = new RespuestaListarTipo();
                RespuestaTotalLiquidaciones total = new RespuestaTotalLiquidaciones();
                respuesta = liquidacionService.ListarTipo("S");
                MessageBox.Show(respuesta.Mensaje);
                Tabla.DataSource = respuesta.liquidaciones;
                TxtTotalLiquidaciones.Text = " ";
                TxtLiquidacionesContributivo.Text = " ";
                total =  liquidacionService.TotalLiquidacionesTipo("S");
                TxtLiquidacionesSubsidiado.Text = total.Liquidacion.ToString();
                TxtTotalCuotaModeradoraSubsidiado.Text = liquidacionService.TotalCuotaModeradoraTipo("S").ToString();
                TxtTotalCuotaModeradora.Text = " ";
                TxtTotalCuotaModeradoraContributivo.Text = " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tabla.DataSource = null;
            IList<Liquidacion> liquidaciones = new List<Liquidacion>();
            Tabla.DataSource = liquidacionService.FiltroFecha(dtFiltroFecha.Value.Date,dtFiltroFecha.Value.Date);
            liquidaciones = liquidacionService.FiltroFecha(dtFiltroFecha.Value.Date, dtFiltroFecha.Value.Date);
            TxtTotalLiquidaciones.Text = liquidacionService.TotalLiquidaciones(liquidaciones).ToString();
            TxtLiquidacionesContributivo.Text = liquidacionService.TotalLiquidacionesTipo("C", liquidaciones).ToString();
            TxtLiquidacionesSubsidiado.Text = liquidacionService.TotalLiquidacionesTipo("S", liquidaciones).ToString();
            TxtTotalCuotaModeradora.Text = liquidacionService.TotalCuotaModeradora(liquidaciones).ToString();
            TxtTotalCuotaModeradoraContributivo.Text = liquidacionService.TotalCuotaModeradoraTipo("C", liquidaciones).ToString();
            TxtTotalCuotaModeradoraSubsidiado.Text = liquidacionService.TotalCuotaModeradoraTipo("S", liquidaciones).ToString();
        }

        private void TxtFiltrarCoincidencia_TextChanged(object sender, EventArgs e)
        {
            Tabla.DataSource = null;
            IList<Liquidacion> liquidaciones = new List<Liquidacion>();
            liquidaciones = liquidacionService.BuscarContiene(TxtFiltrarCoincidencia.Text);
            Tabla.DataSource = liquidaciones;
        }
    }
}
