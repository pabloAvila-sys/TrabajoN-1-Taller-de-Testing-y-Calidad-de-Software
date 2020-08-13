namespace SistemaDeFacturacion
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblfechaemision = new System.Windows.Forms.Label();
            this.lblfechavencimiento = new System.Windows.Forms.Label();
            this.lblformadepago = new System.Windows.Forms.Label();
            this.lblNumfactura = new System.Windows.Forms.Label();
            this.dateTimePickerfechaemision = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerfechavencimiento = new System.Windows.Forms.DateTimePicker();
            this.comboBoxformapago = new System.Windows.Forms.ComboBox();
            this.txtnumfactura = new System.Windows.Forms.TextBox();
            this.lblfono = new System.Windows.Forms.Label();
            this.txtfono = new System.Windows.Forms.TextBox();
            this.lblcliente = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.lblrutcliente = new System.Windows.Forms.Label();
            this.txtrutcliente = new System.Windows.Forms.TextBox();
            this.btnBuscarcliente = new System.Windows.Forms.Button();
            this.lblgiro = new System.Windows.Forms.Label();
            this.txtgiro = new System.Windows.Forms.TextBox();
            this.lblcomuna = new System.Windows.Forms.Label();
            this.txtComuna = new System.Windows.Forms.TextBox();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblcodigoproducto = new System.Windows.Forms.Label();
            this.txtcodigoproducto = new System.Windows.Forms.TextBox();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.comboBoxdescripcion = new System.Windows.Forms.ComboBox();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.lblpreciounitario = new System.Windows.Forms.Label();
            this.txtpreciounitario = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnpagar = new System.Windows.Forms.Button();
            this.btnvolvermenu = new System.Windows.Forms.Button();
            this.lblvalorneto = new System.Windows.Forms.Label();
            this.txtvalorneto = new System.Windows.Forms.TextBox();
            this.lblexento = new System.Windows.Forms.Label();
            this.txtExento = new System.Windows.Forms.TextBox();
            this.lblIVA = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblfechaemision
            // 
            this.lblfechaemision.AutoSize = true;
            this.lblfechaemision.Location = new System.Drawing.Point(12, 9);
            this.lblfechaemision.Name = "lblfechaemision";
            this.lblfechaemision.Size = new System.Drawing.Size(127, 17);
            this.lblfechaemision.TabIndex = 1;
            this.lblfechaemision.Text = "Fecha de Emisión";
            // 
            // lblfechavencimiento
            // 
            this.lblfechavencimiento.AutoSize = true;
            this.lblfechavencimiento.Location = new System.Drawing.Point(202, 9);
            this.lblfechavencimiento.Name = "lblfechavencimiento";
            this.lblfechavencimiento.Size = new System.Drawing.Size(137, 17);
            this.lblfechavencimiento.TabIndex = 2;
            this.lblfechavencimiento.Text = "Fecha Vencimiento";
            // 
            // lblformadepago
            // 
            this.lblformadepago.AutoSize = true;
            this.lblformadepago.Location = new System.Drawing.Point(396, 9);
            this.lblformadepago.Name = "lblformadepago";
            this.lblformadepago.Size = new System.Drawing.Size(109, 17);
            this.lblformadepago.TabIndex = 3;
            this.lblformadepago.Text = "Forma de Pago";
            // 
            // lblNumfactura
            // 
            this.lblNumfactura.AutoSize = true;
            this.lblNumfactura.Location = new System.Drawing.Point(578, 9);
            this.lblNumfactura.Name = "lblNumfactura";
            this.lblNumfactura.Size = new System.Drawing.Size(78, 17);
            this.lblNumfactura.TabIndex = 4;
            this.lblNumfactura.Text = "N° Factura";
            // 
            // dateTimePickerfechaemision
            // 
            this.dateTimePickerfechaemision.Location = new System.Drawing.Point(15, 38);
            this.dateTimePickerfechaemision.Name = "dateTimePickerfechaemision";
            this.dateTimePickerfechaemision.Size = new System.Drawing.Size(166, 25);
            this.dateTimePickerfechaemision.TabIndex = 6;
            // 
            // dateTimePickerfechavencimiento
            // 
            this.dateTimePickerfechavencimiento.Location = new System.Drawing.Point(205, 38);
            this.dateTimePickerfechavencimiento.Name = "dateTimePickerfechavencimiento";
            this.dateTimePickerfechavencimiento.Size = new System.Drawing.Size(167, 25);
            this.dateTimePickerfechavencimiento.TabIndex = 7;
            // 
            // comboBoxformapago
            // 
            this.comboBoxformapago.AutoCompleteCustomSource.AddRange(new string[] {
            "Credito",
            "Efectivo"});
            this.comboBoxformapago.FormattingEnabled = true;
            this.comboBoxformapago.Items.AddRange(new object[] {
            "Crédito",
            "Efectivo"});
            this.comboBoxformapago.Location = new System.Drawing.Point(399, 41);
            this.comboBoxformapago.Name = "comboBoxformapago";
            this.comboBoxformapago.Size = new System.Drawing.Size(121, 25);
            this.comboBoxformapago.TabIndex = 8;
            // 
            // txtnumfactura
            // 
            this.txtnumfactura.Location = new System.Drawing.Point(581, 41);
            this.txtnumfactura.Name = "txtnumfactura";
            this.txtnumfactura.Size = new System.Drawing.Size(113, 25);
            this.txtnumfactura.TabIndex = 9;
            this.txtnumfactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumfactura_KeyPress);
            // 
            // lblfono
            // 
            this.lblfono.AutoSize = true;
            this.lblfono.Location = new System.Drawing.Point(724, 38);
            this.lblfono.Name = "lblfono";
            this.lblfono.Size = new System.Drawing.Size(42, 17);
            this.lblfono.TabIndex = 10;
            this.lblfono.Text = "Fono";
            // 
            // txtfono
            // 
            this.txtfono.Location = new System.Drawing.Point(772, 35);
            this.txtfono.Name = "txtfono";
            this.txtfono.Size = new System.Drawing.Size(179, 25);
            this.txtfono.TabIndex = 11;
            this.txtfono.TextChanged += new System.EventHandler(this.txtfono_TextChanged);
            this.txtfono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfono_KeyPress);
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Location = new System.Drawing.Point(12, 107);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(72, 17);
            this.lblcliente.TabIndex = 12;
            this.lblcliente.Text = "CLIENTE:";
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(90, 104);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(226, 25);
            this.txtcliente.TabIndex = 16;
            this.txtcliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcliente_KeyPress);
            // 
            // lblrutcliente
            // 
            this.lblrutcliente.AutoSize = true;
            this.lblrutcliente.Location = new System.Drawing.Point(337, 107);
            this.lblrutcliente.Name = "lblrutcliente";
            this.lblrutcliente.Size = new System.Drawing.Size(94, 17);
            this.lblrutcliente.TabIndex = 17;
            this.lblrutcliente.Text = "RUT Cliente:";
            // 
            // txtrutcliente
            // 
            this.txtrutcliente.Location = new System.Drawing.Point(437, 104);
            this.txtrutcliente.Name = "txtrutcliente";
            this.txtrutcliente.Size = new System.Drawing.Size(170, 25);
            this.txtrutcliente.TabIndex = 18;
            // 
            // btnBuscarcliente
            // 
            this.btnBuscarcliente.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnBuscarcliente.Location = new System.Drawing.Point(628, 98);
            this.btnBuscarcliente.Name = "btnBuscarcliente";
            this.btnBuscarcliente.Size = new System.Drawing.Size(120, 35);
            this.btnBuscarcliente.TabIndex = 19;
            this.btnBuscarcliente.Text = "Buscar Cliente";
            this.btnBuscarcliente.UseVisualStyleBackColor = true;
            // 
            // lblgiro
            // 
            this.lblgiro.AutoSize = true;
            this.lblgiro.Location = new System.Drawing.Point(769, 107);
            this.lblgiro.Name = "lblgiro";
            this.lblgiro.Size = new System.Drawing.Size(43, 17);
            this.lblgiro.TabIndex = 20;
            this.lblgiro.Text = "Giro:";
            // 
            // txtgiro
            // 
            this.txtgiro.Location = new System.Drawing.Point(818, 104);
            this.txtgiro.Name = "txtgiro";
            this.txtgiro.Size = new System.Drawing.Size(179, 25);
            this.txtgiro.TabIndex = 21;
            // 
            // lblcomuna
            // 
            this.lblcomuna.AutoSize = true;
            this.lblcomuna.Location = new System.Drawing.Point(12, 166);
            this.lblcomuna.Name = "lblcomuna";
            this.lblcomuna.Size = new System.Drawing.Size(69, 17);
            this.lblcomuna.TabIndex = 22;
            this.lblcomuna.Text = "Comuna:";
            // 
            // txtComuna
            // 
            this.txtComuna.Location = new System.Drawing.Point(90, 163);
            this.txtComuna.Name = "txtComuna";
            this.txtComuna.Size = new System.Drawing.Size(226, 25);
            this.txtComuna.TabIndex = 23;
            this.txtComuna.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Location = new System.Drawing.Point(337, 171);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(80, 17);
            this.lbldireccion.TabIndex = 24;
            this.lbldireccion.Text = "Dirección:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(423, 166);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(252, 25);
            this.textBox2.TabIndex = 25;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(696, 169);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(52, 17);
            this.lblemail.TabIndex = 26;
            this.lblemail.Text = "Email:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(754, 163);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(217, 25);
            this.txtemail.TabIndex = 27;
            // 
            // lblcodigoproducto
            // 
            this.lblcodigoproducto.AutoSize = true;
            this.lblcodigoproducto.Location = new System.Drawing.Point(12, 227);
            this.lblcodigoproducto.Name = "lblcodigoproducto";
            this.lblcodigoproducto.Size = new System.Drawing.Size(124, 17);
            this.lblcodigoproducto.TabIndex = 28;
            this.lblcodigoproducto.Text = "Código Producto";
            // 
            // txtcodigoproducto
            // 
            this.txtcodigoproducto.Location = new System.Drawing.Point(15, 247);
            this.txtcodigoproducto.Name = "txtcodigoproducto";
            this.txtcodigoproducto.Size = new System.Drawing.Size(121, 25);
            this.txtcodigoproducto.TabIndex = 29;
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(192, 227);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(92, 17);
            this.lbldescripcion.TabIndex = 30;
            this.lbldescripcion.Text = "Descripción";
            // 
            // comboBoxdescripcion
            // 
            this.comboBoxdescripcion.AutoCompleteCustomSource.AddRange(new string[] {
            "Monitor Dell",
            "Teclado asus",
            "Mouse HP",
            "ROUTER 5G",
            "Disco Duro 1TB",
            "Audifonos Bluetooth",
            "Parlantes Boss",
            "Microfono Asus"});
            this.comboBoxdescripcion.FormattingEnabled = true;
            this.comboBoxdescripcion.Items.AddRange(new object[] {
            "Router Asus 5G",
            "Teclado Dell",
            "Monitor HP",
            "Disco Duro 1TB",
            "Set Limpieza 4comp",
            "Windows 10 + Licencia"});
            this.comboBoxdescripcion.Location = new System.Drawing.Point(195, 247);
            this.comboBoxdescripcion.Name = "comboBoxdescripcion";
            this.comboBoxdescripcion.Size = new System.Drawing.Size(292, 25);
            this.comboBoxdescripcion.TabIndex = 31;
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(515, 227);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(70, 17);
            this.lblcantidad.TabIndex = 32;
            this.lblcantidad.Text = "Cantidad";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(518, 247);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 25);
            this.txtcantidad.TabIndex = 33;
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            // 
            // lblpreciounitario
            // 
            this.lblpreciounitario.AutoSize = true;
            this.lblpreciounitario.Location = new System.Drawing.Point(652, 227);
            this.lblpreciounitario.Name = "lblpreciounitario";
            this.lblpreciounitario.Size = new System.Drawing.Size(114, 17);
            this.lblpreciounitario.TabIndex = 34;
            this.lblpreciounitario.Text = "Precio Unitario";
            // 
            // txtpreciounitario
            // 
            this.txtpreciounitario.Location = new System.Drawing.Point(655, 247);
            this.txtpreciounitario.Name = "txtpreciounitario";
            this.txtpreciounitario.Size = new System.Drawing.Size(170, 25);
            this.txtpreciounitario.TabIndex = 35;
            this.txtpreciounitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpreciounitario_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(28, 289);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(943, 150);
            this.dataGridView1.TabIndex = 36;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo Producto";
            this.Column1.MaxInputLength = 1000;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripción";
            this.Column2.Name = "Column2";
            this.Column2.Width = 400;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio Unitario";
            this.Column4.Name = "Column4";
            this.Column4.Width = 300;
            // 
            // btnguardar
            // 
            this.btnguardar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnguardar.Location = new System.Drawing.Point(28, 454);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(122, 52);
            this.btnguardar.TabIndex = 37;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnlimpiar.Location = new System.Drawing.Point(179, 454);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(117, 52);
            this.btnlimpiar.TabIndex = 38;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.ForeColor = System.Drawing.Color.Orange;
            this.btncalcular.Location = new System.Drawing.Point(325, 454);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(130, 52);
            this.btncalcular.TabIndex = 39;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnsalir.Location = new System.Drawing.Point(28, 549);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(122, 50);
            this.btnsalir.TabIndex = 40;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnpagar
            // 
            this.btnpagar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnpagar.Location = new System.Drawing.Point(179, 549);
            this.btnpagar.Name = "btnpagar";
            this.btnpagar.Size = new System.Drawing.Size(117, 50);
            this.btnpagar.TabIndex = 41;
            this.btnpagar.Text = "Pagar";
            this.btnpagar.UseVisualStyleBackColor = true;
            // 
            // btnvolvermenu
            // 
            this.btnvolvermenu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnvolvermenu.Location = new System.Drawing.Point(325, 549);
            this.btnvolvermenu.Name = "btnvolvermenu";
            this.btnvolvermenu.Size = new System.Drawing.Size(130, 51);
            this.btnvolvermenu.TabIndex = 42;
            this.btnvolvermenu.Text = "Volver al Menú";
            this.btnvolvermenu.UseVisualStyleBackColor = true;
            this.btnvolvermenu.Click += new System.EventHandler(this.btnvolvermenu_Click);
            // 
            // lblvalorneto
            // 
            this.lblvalorneto.AutoSize = true;
            this.lblvalorneto.Location = new System.Drawing.Point(663, 454);
            this.lblvalorneto.Name = "lblvalorneto";
            this.lblvalorneto.Size = new System.Drawing.Size(85, 17);
            this.lblvalorneto.TabIndex = 43;
            this.lblvalorneto.Text = "Valor Neto:";
            // 
            // txtvalorneto
            // 
            this.txtvalorneto.Location = new System.Drawing.Point(754, 454);
            this.txtvalorneto.Name = "txtvalorneto";
            this.txtvalorneto.Size = new System.Drawing.Size(187, 25);
            this.txtvalorneto.TabIndex = 44;
            // 
            // lblexento
            // 
            this.lblexento.AutoSize = true;
            this.lblexento.Location = new System.Drawing.Point(663, 500);
            this.lblexento.Name = "lblexento";
            this.lblexento.Size = new System.Drawing.Size(60, 17);
            this.lblexento.TabIndex = 45;
            this.lblexento.Text = "Exento:";
            // 
            // txtExento
            // 
            this.txtExento.Location = new System.Drawing.Point(754, 500);
            this.txtExento.Name = "txtExento";
            this.txtExento.Size = new System.Drawing.Size(187, 25);
            this.txtExento.TabIndex = 46;
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Location = new System.Drawing.Point(663, 549);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(36, 17);
            this.lblIVA.TabIndex = 47;
            this.lblIVA.Text = "IVA:";
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(754, 549);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.Size = new System.Drawing.Size(187, 25);
            this.txtIVA.TabIndex = 48;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(663, 602);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(58, 17);
            this.lbltotal.TabIndex = 49;
            this.lbltotal.Text = "TOTAL:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(754, 599);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(187, 25);
            this.txtTotal.TabIndex = 50;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 650);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.txtIVA);
            this.Controls.Add(this.lblIVA);
            this.Controls.Add(this.txtExento);
            this.Controls.Add(this.lblexento);
            this.Controls.Add(this.txtvalorneto);
            this.Controls.Add(this.lblvalorneto);
            this.Controls.Add(this.btnvolvermenu);
            this.Controls.Add(this.btnpagar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtpreciounitario);
            this.Controls.Add(this.lblpreciounitario);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.comboBoxdescripcion);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.txtcodigoproducto);
            this.Controls.Add(this.lblcodigoproducto);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbldireccion);
            this.Controls.Add(this.txtComuna);
            this.Controls.Add(this.lblcomuna);
            this.Controls.Add(this.txtgiro);
            this.Controls.Add(this.lblgiro);
            this.Controls.Add(this.btnBuscarcliente);
            this.Controls.Add(this.txtrutcliente);
            this.Controls.Add(this.lblrutcliente);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.lblcliente);
            this.Controls.Add(this.txtfono);
            this.Controls.Add(this.lblfono);
            this.Controls.Add(this.txtnumfactura);
            this.Controls.Add(this.comboBoxformapago);
            this.Controls.Add(this.dateTimePickerfechavencimiento);
            this.Controls.Add(this.dateTimePickerfechaemision);
            this.Controls.Add(this.lblNumfactura);
            this.Controls.Add(this.lblformadepago);
            this.Controls.Add(this.lblfechavencimiento);
            this.Controls.Add(this.lblfechaemision);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Facturación";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfechaemision;
        private System.Windows.Forms.Label lblfechavencimiento;
        private System.Windows.Forms.Label lblformadepago;
        private System.Windows.Forms.Label lblNumfactura;
        private System.Windows.Forms.DateTimePicker dateTimePickerfechaemision;
        private System.Windows.Forms.DateTimePicker dateTimePickerfechavencimiento;
        private System.Windows.Forms.ComboBox comboBoxformapago;
        private System.Windows.Forms.TextBox txtnumfactura;
        private System.Windows.Forms.Label lblfono;
        private System.Windows.Forms.TextBox txtfono;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.Label lblrutcliente;
        private System.Windows.Forms.TextBox txtrutcliente;
        private System.Windows.Forms.Button btnBuscarcliente;
        private System.Windows.Forms.Label lblgiro;
        private System.Windows.Forms.TextBox txtgiro;
        private System.Windows.Forms.Label lblcomuna;
        private System.Windows.Forms.TextBox txtComuna;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblcodigoproducto;
        private System.Windows.Forms.TextBox txtcodigoproducto;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.ComboBox comboBoxdescripcion;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label lblpreciounitario;
        private System.Windows.Forms.TextBox txtpreciounitario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnpagar;
        private System.Windows.Forms.Button btnvolvermenu;
        private System.Windows.Forms.Label lblvalorneto;
        private System.Windows.Forms.TextBox txtvalorneto;
        private System.Windows.Forms.Label lblexento;
        private System.Windows.Forms.TextBox txtExento;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txtTotal;
    }
}