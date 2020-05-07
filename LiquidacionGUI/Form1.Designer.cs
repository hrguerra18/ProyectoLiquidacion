namespace LiquidacionGUI
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.NumeroLiquidacionLbl = new System.Windows.Forms.Label();
            this.NumeroLiquidacionTxt = new System.Windows.Forms.TextBox();
            this.TipoAfiliacionCmb = new System.Windows.Forms.ComboBox();
            this.IdentificacionLbl = new System.Windows.Forms.Label();
            this.TipoAfiliacionLbl = new System.Windows.Forms.Label();
            this.SalarioLbl = new System.Windows.Forms.Label();
            this.ValorServicioLbl = new System.Windows.Forms.Label();
            this.TarifaLbl = new System.Windows.Forms.Label();
            this.CuotaModeradoraLbl = new System.Windows.Forms.Label();
            this.IdentificacionTxt = new System.Windows.Forms.TextBox();
            this.SalarioTxt = new System.Windows.Forms.TextBox();
            this.ValorServicioTxt = new System.Windows.Forms.TextBox();
            this.TarifaTxt = new System.Windows.Forms.TextBox();
            this.CuotaModeradoraTxt = new System.Windows.Forms.TextBox();
            this.GuardarBtn = new System.Windows.Forms.Button();
            this.Tabla = new System.Windows.Forms.DataGridView();
            this.ConsultarBtn = new System.Windows.Forms.Button();
            this.EliminarBtn = new System.Windows.Forms.Button();
            this.ModificarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // NumeroLiquidacionLbl
            // 
            this.NumeroLiquidacionLbl.AutoSize = true;
            this.NumeroLiquidacionLbl.Location = new System.Drawing.Point(48, 44);
            this.NumeroLiquidacionLbl.Name = "NumeroLiquidacionLbl";
            this.NumeroLiquidacionLbl.Size = new System.Drawing.Size(116, 13);
            this.NumeroLiquidacionLbl.TabIndex = 0;
            this.NumeroLiquidacionLbl.Text = "Numero de Liquidacion";
            // 
            // NumeroLiquidacionTxt
            // 
            this.NumeroLiquidacionTxt.Location = new System.Drawing.Point(169, 37);
            this.NumeroLiquidacionTxt.Name = "NumeroLiquidacionTxt";
            this.NumeroLiquidacionTxt.Size = new System.Drawing.Size(100, 20);
            this.NumeroLiquidacionTxt.TabIndex = 2;
            // 
            // TipoAfiliacionCmb
            // 
            this.TipoAfiliacionCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoAfiliacionCmb.FormattingEnabled = true;
            this.TipoAfiliacionCmb.Items.AddRange(new object[] {
            "S",
            "C"});
            this.TipoAfiliacionCmb.Location = new System.Drawing.Point(170, 101);
            this.TipoAfiliacionCmb.Name = "TipoAfiliacionCmb";
            this.TipoAfiliacionCmb.Size = new System.Drawing.Size(100, 21);
            this.TipoAfiliacionCmb.TabIndex = 1;
            // 
            // IdentificacionLbl
            // 
            this.IdentificacionLbl.AutoSize = true;
            this.IdentificacionLbl.Location = new System.Drawing.Point(94, 76);
            this.IdentificacionLbl.Name = "IdentificacionLbl";
            this.IdentificacionLbl.Size = new System.Drawing.Size(70, 13);
            this.IdentificacionLbl.TabIndex = 3;
            this.IdentificacionLbl.Text = "Identificacion";
            // 
            // TipoAfiliacionLbl
            // 
            this.TipoAfiliacionLbl.AutoSize = true;
            this.TipoAfiliacionLbl.Location = new System.Drawing.Point(91, 108);
            this.TipoAfiliacionLbl.Name = "TipoAfiliacionLbl";
            this.TipoAfiliacionLbl.Size = new System.Drawing.Size(73, 13);
            this.TipoAfiliacionLbl.TabIndex = 4;
            this.TipoAfiliacionLbl.Text = "Tipo Afilicaion";
            // 
            // SalarioLbl
            // 
            this.SalarioLbl.AutoSize = true;
            this.SalarioLbl.Location = new System.Drawing.Point(121, 172);
            this.SalarioLbl.Name = "SalarioLbl";
            this.SalarioLbl.Size = new System.Drawing.Size(42, 13);
            this.SalarioLbl.TabIndex = 5;
            this.SalarioLbl.Text = "Salario ";
            // 
            // ValorServicioLbl
            // 
            this.ValorServicioLbl.AutoSize = true;
            this.ValorServicioLbl.Location = new System.Drawing.Point(94, 204);
            this.ValorServicioLbl.Name = "ValorServicioLbl";
            this.ValorServicioLbl.Size = new System.Drawing.Size(72, 13);
            this.ValorServicioLbl.TabIndex = 6;
            this.ValorServicioLbl.Text = "Valor Servicio";
            // 
            // TarifaLbl
            // 
            this.TarifaLbl.AutoSize = true;
            this.TarifaLbl.Location = new System.Drawing.Point(130, 236);
            this.TarifaLbl.Name = "TarifaLbl";
            this.TarifaLbl.Size = new System.Drawing.Size(34, 13);
            this.TarifaLbl.TabIndex = 7;
            this.TarifaLbl.Text = "Tarifa";
            // 
            // CuotaModeradoraLbl
            // 
            this.CuotaModeradoraLbl.AutoSize = true;
            this.CuotaModeradoraLbl.Location = new System.Drawing.Point(69, 268);
            this.CuotaModeradoraLbl.Name = "CuotaModeradoraLbl";
            this.CuotaModeradoraLbl.Size = new System.Drawing.Size(95, 13);
            this.CuotaModeradoraLbl.TabIndex = 8;
            this.CuotaModeradoraLbl.Text = "Cuota Moderadora";
            // 
            // IdentificacionTxt
            // 
            this.IdentificacionTxt.Location = new System.Drawing.Point(169, 69);
            this.IdentificacionTxt.Name = "IdentificacionTxt";
            this.IdentificacionTxt.Size = new System.Drawing.Size(100, 20);
            this.IdentificacionTxt.TabIndex = 3;
            // 
            // SalarioTxt
            // 
            this.SalarioTxt.Location = new System.Drawing.Point(169, 166);
            this.SalarioTxt.Name = "SalarioTxt";
            this.SalarioTxt.Size = new System.Drawing.Size(100, 20);
            this.SalarioTxt.TabIndex = 4;
            // 
            // ValorServicioTxt
            // 
            this.ValorServicioTxt.Location = new System.Drawing.Point(169, 198);
            this.ValorServicioTxt.Name = "ValorServicioTxt";
            this.ValorServicioTxt.Size = new System.Drawing.Size(100, 20);
            this.ValorServicioTxt.TabIndex = 5;
            // 
            // TarifaTxt
            // 
            this.TarifaTxt.Location = new System.Drawing.Point(169, 230);
            this.TarifaTxt.Name = "TarifaTxt";
            this.TarifaTxt.Size = new System.Drawing.Size(100, 20);
            this.TarifaTxt.TabIndex = 6;
            // 
            // CuotaModeradoraTxt
            // 
            this.CuotaModeradoraTxt.Location = new System.Drawing.Point(169, 262);
            this.CuotaModeradoraTxt.Name = "CuotaModeradoraTxt";
            this.CuotaModeradoraTxt.Size = new System.Drawing.Size(100, 20);
            this.CuotaModeradoraTxt.TabIndex = 7;
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.Location = new System.Drawing.Point(411, 30);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(77, 41);
            this.GuardarBtn.TabIndex = 8;
            this.GuardarBtn.Text = "Guardar";
            this.GuardarBtn.UseVisualStyleBackColor = true;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // Tabla
            // 
            this.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabla.Location = new System.Drawing.Point(51, 353);
            this.Tabla.Name = "Tabla";
            this.Tabla.Size = new System.Drawing.Size(513, 136);
            this.Tabla.TabIndex = 9;
            this.Tabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tabla_CellClick);
            this.Tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tabla_CellContentClick);
            // 
            // ConsultarBtn
            // 
            this.ConsultarBtn.Location = new System.Drawing.Point(411, 92);
            this.ConsultarBtn.Name = "ConsultarBtn";
            this.ConsultarBtn.Size = new System.Drawing.Size(75, 41);
            this.ConsultarBtn.TabIndex = 10;
            this.ConsultarBtn.Text = "Consultar";
            this.ConsultarBtn.UseVisualStyleBackColor = true;
            this.ConsultarBtn.Click += new System.EventHandler(this.ConsultarBtn_Click);
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.Location = new System.Drawing.Point(411, 151);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Size = new System.Drawing.Size(75, 45);
            this.EliminarBtn.TabIndex = 11;
            this.EliminarBtn.Text = "Eliminar";
            this.EliminarBtn.UseVisualStyleBackColor = true;
            this.EliminarBtn.Click += new System.EventHandler(this.EliminarBtn_Click);
            // 
            // ModificarBtn
            // 
            this.ModificarBtn.Location = new System.Drawing.Point(411, 213);
            this.ModificarBtn.Name = "ModificarBtn";
            this.ModificarBtn.Size = new System.Drawing.Size(75, 46);
            this.ModificarBtn.TabIndex = 12;
            this.ModificarBtn.Text = "Modificar";
            this.ModificarBtn.UseVisualStyleBackColor = true;
            this.ModificarBtn.Click += new System.EventHandler(this.ModificarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fecha";
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(170, 134);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(100, 20);
            this.dtFecha.TabIndex = 14;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 501);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ModificarBtn);
            this.Controls.Add(this.EliminarBtn);
            this.Controls.Add(this.ConsultarBtn);
            this.Controls.Add(this.Tabla);
            this.Controls.Add(this.GuardarBtn);
            this.Controls.Add(this.CuotaModeradoraTxt);
            this.Controls.Add(this.TarifaTxt);
            this.Controls.Add(this.ValorServicioTxt);
            this.Controls.Add(this.SalarioTxt);
            this.Controls.Add(this.IdentificacionTxt);
            this.Controls.Add(this.CuotaModeradoraLbl);
            this.Controls.Add(this.TarifaLbl);
            this.Controls.Add(this.ValorServicioLbl);
            this.Controls.Add(this.SalarioLbl);
            this.Controls.Add(this.TipoAfiliacionLbl);
            this.Controls.Add(this.IdentificacionLbl);
            this.Controls.Add(this.TipoAfiliacionCmb);
            this.Controls.Add(this.NumeroLiquidacionTxt);
            this.Controls.Add(this.NumeroLiquidacionLbl);
            this.Name = "Principal";
            this.Text = "LiquidacionFrm";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NumeroLiquidacionLbl;
        private System.Windows.Forms.TextBox NumeroLiquidacionTxt;
        private System.Windows.Forms.ComboBox TipoAfiliacionCmb;
        private System.Windows.Forms.Label IdentificacionLbl;
        private System.Windows.Forms.Label TipoAfiliacionLbl;
        private System.Windows.Forms.Label SalarioLbl;
        private System.Windows.Forms.Label ValorServicioLbl;
        private System.Windows.Forms.Label TarifaLbl;
        private System.Windows.Forms.Label CuotaModeradoraLbl;
        private System.Windows.Forms.TextBox IdentificacionTxt;
        private System.Windows.Forms.TextBox SalarioTxt;
        private System.Windows.Forms.TextBox ValorServicioTxt;
        private System.Windows.Forms.TextBox TarifaTxt;
        private System.Windows.Forms.TextBox CuotaModeradoraTxt;
        private System.Windows.Forms.Button GuardarBtn;
        private System.Windows.Forms.DataGridView Tabla;
        private System.Windows.Forms.Button ConsultarBtn;
        private System.Windows.Forms.Button EliminarBtn;
        private System.Windows.Forms.Button ModificarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFecha;
    }
}

