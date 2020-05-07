using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace LiquidacionGUI
{
    public partial class Principal : Form
    {
        LiquidacionService liquidacionService = new LiquidacionService();
        public Principal()
        {
            InitializeComponent();
            LlenarTabla();
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            string mensaje = liquidacionService.Guardar(CrearLiquidacion());
            MessageBox.Show(mensaje, "Mensaje de guardar datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LlenarTabla();
            Limpiar();
        }
        private void LlenarTabla()
        {
            Tabla.DataSource = null;
            RespuestaConsultar respuesta = new RespuestaConsultar();
            respuesta = liquidacionService.Consultar();
            Tabla.DataSource = respuesta.liquidaciones;
            Tabla.Columns[9].Visible = false;
        }

        private void Limpiar()
        {
            NumeroLiquidacionTxt.Text = " ";
            IdentificacionTxt.Text = " ";
            TipoAfiliacionCmb.Text = " ";
           
            SalarioTxt.Text = " ";
            ValorServicioTxt.Text = " ";
            TarifaTxt.Text = " ";
            CuotaModeradoraTxt.Text = " ";
        }


        private Liquidacion CrearLiquidacion()
        {
            Liquidacion liquidacion = null;
            if (TipoAfiliacionCmb.Text.Equals("S"))
            {
                liquidacion = new LiquidacionSubsidiado();

               
            }
            else if (TipoAfiliacionCmb.Text.Equals("C"))
            {
                liquidacion = new LiquidacionContributivo();
            }
            liquidacion.TipoAfiliacion = TipoAfiliacionCmb.Text;
            liquidacion.NumeroLiquidacion = NumeroLiquidacionTxt.Text;
            liquidacion.Identificacion = IdentificacionTxt.Text;
            liquidacion.Fecha = dtFecha.Value.Date;
            liquidacion.SalarioDevengado = Convert.ToInt32(SalarioTxt.Text);
            liquidacion.ValorServicio = Convert.ToDouble(ValorServicioTxt.Text);
            liquidacion.Tarifa = liquidacion.CalcularTarifa();
            liquidacion.Tope = liquidacion.CalcularTope();
            liquidacion.CuotaModeradora = liquidacion.CalcularCuotaModeradora();
            TarifaTxt.Text = Convert.ToString(liquidacion.Tarifa);
            CuotaModeradoraTxt.Text = Convert.ToString(liquidacion.CuotaModeradora);

            return liquidacion;
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void ConsultarBtn_Click(object sender, EventArgs e)
        {
            ConsultoLiquidacionFrm consultoLiquidacion = new ConsultoLiquidacionFrm();
            consultoLiquidacion.Show();
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            string mensaje = liquidacionService.Eliminar(NumeroLiquidacionTxt.Text);
            MessageBox.Show(mensaje, "Mensaje de eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LlenarTabla();
            Limpiar();
        }

        private void Tabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NumeroLiquidacionTxt.Text = Tabla.CurrentRow.Cells[0].Value.ToString();
            IdentificacionTxt.Text = Tabla.CurrentRow.Cells[1].Value.ToString();
            TipoAfiliacionCmb.Text = Tabla.CurrentRow.Cells[2].Value.ToString();
            dtFecha.Value = Convert.ToDateTime(Tabla.CurrentRow.Cells[3].Value);
            SalarioTxt.Text = Tabla.CurrentRow.Cells[4].Value.ToString();
            ValorServicioTxt.Text = Tabla.CurrentRow.Cells[5].Value.ToString();
            

        }

        private void ModificarBtn_Click(object sender, EventArgs e)
        {

           string mensaje = liquidacionService.Modificar(NumeroLiquidacionTxt.Text, CrearLiquidacion());
            MessageBox.Show(mensaje, "Mensaje de modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LlenarTabla();
            Limpiar();
        }

        private void Tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
