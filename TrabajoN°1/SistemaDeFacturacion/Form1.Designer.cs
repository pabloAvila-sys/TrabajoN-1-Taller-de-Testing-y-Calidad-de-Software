namespace SistemaDeFacturacion
{
    partial class Form1
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
            this.buttoningresarfactura = new System.Windows.Forms.Button();
            this.buttoningresarfactrasmasivas = new System.Windows.Forms.Button();
            this.buttonConsultarfacturas = new System.Windows.Forms.Button();
            this.buttonExportar = new System.Windows.Forms.Button();
            this.buttonmenuproducto = new System.Windows.Forms.Button();
            this.buttonmenuproveedor = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaMenúPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttoningresarfactura
            // 
            this.buttoningresarfactura.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttoningresarfactura.Location = new System.Drawing.Point(72, 39);
            this.buttoningresarfactura.Name = "buttoningresarfactura";
            this.buttoningresarfactura.Size = new System.Drawing.Size(109, 70);
            this.buttoningresarfactura.TabIndex = 0;
            this.buttoningresarfactura.Text = "Ingresar factura";
            this.buttoningresarfactura.UseVisualStyleBackColor = true;
            this.buttoningresarfactura.Click += new System.EventHandler(this.buttoningresarfactura_Click);
            // 
            // buttoningresarfactrasmasivas
            // 
            this.buttoningresarfactrasmasivas.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttoningresarfactrasmasivas.Location = new System.Drawing.Point(207, 39);
            this.buttoningresarfactrasmasivas.Name = "buttoningresarfactrasmasivas";
            this.buttoningresarfactrasmasivas.Size = new System.Drawing.Size(116, 70);
            this.buttoningresarfactrasmasivas.TabIndex = 1;
            this.buttoningresarfactrasmasivas.Text = "Ingresar Facturas Masivas";
            this.buttoningresarfactrasmasivas.UseVisualStyleBackColor = true;
            // 
            // buttonConsultarfacturas
            // 
            this.buttonConsultarfacturas.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonConsultarfacturas.Location = new System.Drawing.Point(72, 134);
            this.buttonConsultarfacturas.Name = "buttonConsultarfacturas";
            this.buttonConsultarfacturas.Size = new System.Drawing.Size(109, 62);
            this.buttonConsultarfacturas.TabIndex = 2;
            this.buttonConsultarfacturas.Text = "Consultar Facturas";
            this.buttonConsultarfacturas.UseVisualStyleBackColor = true;
            // 
            // buttonExportar
            // 
            this.buttonExportar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonExportar.Location = new System.Drawing.Point(207, 134);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(116, 62);
            this.buttonExportar.TabIndex = 3;
            this.buttonExportar.Text = "Exportar a Excel o PDF";
            this.buttonExportar.UseVisualStyleBackColor = true;
            // 
            // buttonmenuproducto
            // 
            this.buttonmenuproducto.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonmenuproducto.Location = new System.Drawing.Point(72, 224);
            this.buttonmenuproducto.Name = "buttonmenuproducto";
            this.buttonmenuproducto.Size = new System.Drawing.Size(109, 55);
            this.buttonmenuproducto.TabIndex = 4;
            this.buttonmenuproducto.Text = "Menú Productos";
            this.buttonmenuproducto.UseVisualStyleBackColor = true;
            // 
            // buttonmenuproveedor
            // 
            this.buttonmenuproveedor.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonmenuproveedor.Location = new System.Drawing.Point(207, 224);
            this.buttonmenuproveedor.Name = "buttonmenuproveedor";
            this.buttonmenuproveedor.Size = new System.Drawing.Size(116, 55);
            this.buttonmenuproveedor.TabIndex = 5;
            this.buttonmenuproveedor.Text = "Menú Proveedor";
            this.buttonmenuproveedor.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(410, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaMenúPrincipalToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // ayudaMenúPrincipalToolStripMenuItem
            // 
            this.ayudaMenúPrincipalToolStripMenuItem.Name = "ayudaMenúPrincipalToolStripMenuItem";
            this.ayudaMenúPrincipalToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.ayudaMenúPrincipalToolStripMenuItem.Text = "Ayuda Menú Principal";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 318);
            this.Controls.Add(this.buttonmenuproveedor);
            this.Controls.Add(this.buttonmenuproducto);
            this.Controls.Add(this.buttonExportar);
            this.Controls.Add(this.buttonConsultarfacturas);
            this.Controls.Add(this.buttoningresarfactrasmasivas);
            this.Controls.Add(this.buttoningresarfactura);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Menú Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttoningresarfactura;
        private System.Windows.Forms.Button buttoningresarfactrasmasivas;
        private System.Windows.Forms.Button buttonConsultarfacturas;
        private System.Windows.Forms.Button buttonExportar;
        private System.Windows.Forms.Button buttonmenuproducto;
        private System.Windows.Forms.Button buttonmenuproveedor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaMenúPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

