namespace Prototipo1p
{
    partial class frmCompraE
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompraE));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCerrar = new System.Windows.Forms.Panel();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.picDepartamento = new System.Windows.Forms.PictureBox();
            this.pnlBotonGuardarCE = new System.Windows.Forms.Panel();
            this.pnlModificarCE = new System.Windows.Forms.Panel();
            this.pnlCampoApellidoEmpleado = new System.Windows.Forms.Panel();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.lblApellidoEmpleado = new System.Windows.Forms.Label();
            this.pnlCampoNombreEmpleado = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.pnlCampoIdUsuario = new System.Windows.Forms.Panel();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.pnlCampoDpiEmpleado = new System.Windows.Forms.Panel();
            this.lblDpiEmpleado = new System.Windows.Forms.Label();
            this.pnlCampoIDE = new System.Windows.Forms.Panel();
            this.txtIdDoc = new System.Windows.Forms.TextBox();
            this.lbnIdEmpleado = new System.Windows.Forms.Label();
            this.dgvCompraE = new System.Windows.Forms.DataGridView();
            this.pnlBotonBuscarCE = new System.Windows.Forms.Panel();
            this.txtBuscarCE = new System.Windows.Forms.TextBox();
            this.cbxProveedor = new System.Windows.Forms.ComboBox();
            this.pnlLLenarCamposPE = new System.Windows.Forms.Panel();
            this.documentocompraencaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoproveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechacompraencaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalcompraencaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatuscompraencaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compraEncabezadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picDepartamento)).BeginInit();
            this.pnlCampoApellidoEmpleado.SuspendLayout();
            this.pnlCampoNombreEmpleado.SuspendLayout();
            this.pnlCampoIdUsuario.SuspendLayout();
            this.pnlCampoDpiEmpleado.SuspendLayout();
            this.pnlCampoIDE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompraE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraEncabezadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCerrar
            // 
            this.pnlCerrar.BackColor = System.Drawing.Color.Transparent;
            this.pnlCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCerrar.BackgroundImage")));
            this.pnlCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlCerrar.Location = new System.Drawing.Point(12, 12);
            this.pnlCerrar.Name = "pnlCerrar";
            this.pnlCerrar.Size = new System.Drawing.Size(33, 33);
            this.pnlCerrar.TabIndex = 359;
            this.pnlCerrar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCerrar_Paint);
            this.pnlCerrar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlCerrar_MouseClick);
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDepartamento.Location = new System.Drawing.Point(874, 11);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(84, 13);
            this.lblDepartamento.TabIndex = 360;
            this.lblDepartamento.Text = "JorgeCastaneda";
            // 
            // picDepartamento
            // 
            this.picDepartamento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picDepartamento.BackgroundImage")));
            this.picDepartamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picDepartamento.Location = new System.Drawing.Point(849, 7);
            this.picDepartamento.Name = "picDepartamento";
            this.picDepartamento.Size = new System.Drawing.Size(20, 21);
            this.picDepartamento.TabIndex = 361;
            this.picDepartamento.TabStop = false;
            // 
            // pnlBotonGuardarCE
            // 
            this.pnlBotonGuardarCE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBotonGuardarCE.BackgroundImage")));
            this.pnlBotonGuardarCE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlBotonGuardarCE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBotonGuardarCE.Location = new System.Drawing.Point(149, 342);
            this.pnlBotonGuardarCE.Name = "pnlBotonGuardarCE";
            this.pnlBotonGuardarCE.Size = new System.Drawing.Size(37, 42);
            this.pnlBotonGuardarCE.TabIndex = 371;
            this.pnlBotonGuardarCE.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlBotonGuardarCE_MouseClick);
            // 
            // pnlModificarCE
            // 
            this.pnlModificarCE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlModificarCE.BackgroundImage")));
            this.pnlModificarCE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlModificarCE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlModificarCE.Location = new System.Drawing.Point(199, 342);
            this.pnlModificarCE.Name = "pnlModificarCE";
            this.pnlModificarCE.Size = new System.Drawing.Size(37, 42);
            this.pnlModificarCE.TabIndex = 362;
            this.pnlModificarCE.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlModificarCE_MouseClick);
            // 
            // pnlCampoApellidoEmpleado
            // 
            this.pnlCampoApellidoEmpleado.Controls.Add(this.txtEstatus);
            this.pnlCampoApellidoEmpleado.Controls.Add(this.lblApellidoEmpleado);
            this.pnlCampoApellidoEmpleado.Location = new System.Drawing.Point(68, 288);
            this.pnlCampoApellidoEmpleado.Name = "pnlCampoApellidoEmpleado";
            this.pnlCampoApellidoEmpleado.Size = new System.Drawing.Size(212, 48);
            this.pnlCampoApellidoEmpleado.TabIndex = 365;
            // 
            // txtEstatus
            // 
            this.txtEstatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEstatus.Location = new System.Drawing.Point(3, 27);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(205, 13);
            this.txtEstatus.TabIndex = 11;
            this.txtEstatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblApellidoEmpleado
            // 
            this.lblApellidoEmpleado.AutoSize = true;
            this.lblApellidoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoEmpleado.Location = new System.Drawing.Point(3, 9);
            this.lblApellidoEmpleado.Name = "lblApellidoEmpleado";
            this.lblApellidoEmpleado.Size = new System.Drawing.Size(169, 13);
            this.lblApellidoEmpleado.TabIndex = 10;
            this.lblApellidoEmpleado.Text = "Estatus Compra Encabezado";
            // 
            // pnlCampoNombreEmpleado
            // 
            this.pnlCampoNombreEmpleado.Controls.Add(this.txtTotal);
            this.pnlCampoNombreEmpleado.Controls.Add(this.lblNombreEmpleado);
            this.pnlCampoNombreEmpleado.Location = new System.Drawing.Point(67, 234);
            this.pnlCampoNombreEmpleado.Name = "pnlCampoNombreEmpleado";
            this.pnlCampoNombreEmpleado.Size = new System.Drawing.Size(212, 48);
            this.pnlCampoNombreEmpleado.TabIndex = 369;
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Location = new System.Drawing.Point(3, 27);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(205, 13);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpleado.Location = new System.Drawing.Point(3, 9);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(156, 13);
            this.lblNombreEmpleado.TabIndex = 10;
            this.lblNombreEmpleado.Text = "Total Compra Encabezado";
            // 
            // pnlCampoIdUsuario
            // 
            this.pnlCampoIdUsuario.Controls.Add(this.txtFecha);
            this.pnlCampoIdUsuario.Controls.Add(this.lblIdUsuario);
            this.pnlCampoIdUsuario.Location = new System.Drawing.Point(66, 178);
            this.pnlCampoIdUsuario.Name = "pnlCampoIdUsuario";
            this.pnlCampoIdUsuario.Size = new System.Drawing.Size(212, 48);
            this.pnlCampoIdUsuario.TabIndex = 368;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(3, 24);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(205, 20);
            this.txtFecha.TabIndex = 36;
            this.txtFecha.ValueChanged += new System.EventHandler(this.txtFechaRecPE_ValueChanged);
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdUsuario.Location = new System.Drawing.Point(3, 9);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(162, 13);
            this.lblIdUsuario.TabIndex = 10;
            this.lblIdUsuario.Text = "Fecha Compra Encabezado";
            // 
            // pnlCampoDpiEmpleado
            // 
            this.pnlCampoDpiEmpleado.Controls.Add(this.cbxProveedor);
            this.pnlCampoDpiEmpleado.Controls.Add(this.lblDpiEmpleado);
            this.pnlCampoDpiEmpleado.Location = new System.Drawing.Point(66, 121);
            this.pnlCampoDpiEmpleado.Name = "pnlCampoDpiEmpleado";
            this.pnlCampoDpiEmpleado.Size = new System.Drawing.Size(212, 48);
            this.pnlCampoDpiEmpleado.TabIndex = 364;
            // 
            // lblDpiEmpleado
            // 
            this.lblDpiEmpleado.AutoSize = true;
            this.lblDpiEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDpiEmpleado.Location = new System.Drawing.Point(3, 9);
            this.lblDpiEmpleado.Name = "lblDpiEmpleado";
            this.lblDpiEmpleado.Size = new System.Drawing.Size(81, 13);
            this.lblDpiEmpleado.TabIndex = 10;
            this.lblDpiEmpleado.Text = "ID proveedor";
            // 
            // pnlCampoIDE
            // 
            this.pnlCampoIDE.Controls.Add(this.txtIdDoc);
            this.pnlCampoIDE.Controls.Add(this.lbnIdEmpleado);
            this.pnlCampoIDE.Location = new System.Drawing.Point(65, 58);
            this.pnlCampoIDE.Name = "pnlCampoIDE";
            this.pnlCampoIDE.Size = new System.Drawing.Size(212, 48);
            this.pnlCampoIDE.TabIndex = 363;
            // 
            // txtIdDoc
            // 
            this.txtIdDoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdDoc.Location = new System.Drawing.Point(3, 27);
            this.txtIdDoc.Name = "txtIdDoc";
            this.txtIdDoc.Size = new System.Drawing.Size(205, 13);
            this.txtIdDoc.TabIndex = 11;
            this.txtIdDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbnIdEmpleado
            // 
            this.lbnIdEmpleado.AutoSize = true;
            this.lbnIdEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnIdEmpleado.Location = new System.Drawing.Point(3, 9);
            this.lbnIdEmpleado.Name = "lbnIdEmpleado";
            this.lbnIdEmpleado.Size = new System.Drawing.Size(208, 13);
            this.lbnIdEmpleado.TabIndex = 10;
            this.lbnIdEmpleado.Text = "ID Documento Compra Encabezado";
            // 
            // dgvCompraE
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgvCompraE.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCompraE.AutoGenerateColumns = false;
            this.dgvCompraE.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(227)))));
            this.dgvCompraE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCompraE.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCompraE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompraE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.documentocompraencaDataGridViewTextBoxColumn,
            this.codigoproveedorDataGridViewTextBoxColumn,
            this.fechacompraencaDataGridViewTextBoxColumn,
            this.totalcompraencaDataGridViewTextBoxColumn,
            this.estatuscompraencaDataGridViewTextBoxColumn});
            this.dgvCompraE.DataSource = this.compraEncabezadoBindingSource;
            this.dgvCompraE.Location = new System.Drawing.Point(310, 121);
            this.dgvCompraE.Name = "dgvCompraE";
            this.dgvCompraE.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(102)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompraE.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCompraE.RowHeadersWidth = 45;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(102)))), ((int)(((byte)(107)))));
            this.dgvCompraE.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCompraE.Size = new System.Drawing.Size(547, 207);
            this.dgvCompraE.TabIndex = 375;
            // 
            // pnlBotonBuscarCE
            // 
            this.pnlBotonBuscarCE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBotonBuscarCE.BackgroundImage")));
            this.pnlBotonBuscarCE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlBotonBuscarCE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBotonBuscarCE.Location = new System.Drawing.Point(660, 79);
            this.pnlBotonBuscarCE.Name = "pnlBotonBuscarCE";
            this.pnlBotonBuscarCE.Size = new System.Drawing.Size(22, 22);
            this.pnlBotonBuscarCE.TabIndex = 377;
            this.pnlBotonBuscarCE.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlBotonBuscarCE_MouseClick);
            // 
            // txtBuscarCE
            // 
            this.txtBuscarCE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarCE.Location = new System.Drawing.Point(418, 79);
            this.txtBuscarCE.Multiline = true;
            this.txtBuscarCE.Name = "txtBuscarCE";
            this.txtBuscarCE.Size = new System.Drawing.Size(221, 20);
            this.txtBuscarCE.TabIndex = 376;
            // 
            // cbxProveedor
            // 
            this.cbxProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProveedor.FormattingEnabled = true;
            this.cbxProveedor.Location = new System.Drawing.Point(2, 24);
            this.cbxProveedor.Name = "cbxProveedor";
            this.cbxProveedor.Size = new System.Drawing.Size(205, 21);
            this.cbxProveedor.TabIndex = 36;
            // 
            // pnlLLenarCamposPE
            // 
            this.pnlLLenarCamposPE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLLenarCamposPE.BackgroundImage")));
            this.pnlLLenarCamposPE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlLLenarCamposPE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlLLenarCamposPE.Location = new System.Drawing.Point(852, 121);
            this.pnlLLenarCamposPE.Name = "pnlLLenarCamposPE";
            this.pnlLLenarCamposPE.Size = new System.Drawing.Size(120, 124);
            this.pnlLLenarCamposPE.TabIndex = 378;
            this.pnlLLenarCamposPE.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlLLenarCamposPE_MouseClick);
            // 
            // documentocompraencaDataGridViewTextBoxColumn
            // 
            this.documentocompraencaDataGridViewTextBoxColumn.DataPropertyName = "Documento_compraenca";
            this.documentocompraencaDataGridViewTextBoxColumn.HeaderText = "Documento Compra Encabezado";
            this.documentocompraencaDataGridViewTextBoxColumn.Name = "documentocompraencaDataGridViewTextBoxColumn";
            // 
            // codigoproveedorDataGridViewTextBoxColumn
            // 
            this.codigoproveedorDataGridViewTextBoxColumn.DataPropertyName = "Codigo_proveedor";
            this.codigoproveedorDataGridViewTextBoxColumn.HeaderText = "Codigo Proveedor";
            this.codigoproveedorDataGridViewTextBoxColumn.Name = "codigoproveedorDataGridViewTextBoxColumn";
            // 
            // fechacompraencaDataGridViewTextBoxColumn
            // 
            this.fechacompraencaDataGridViewTextBoxColumn.DataPropertyName = "Fecha_compraenca";
            this.fechacompraencaDataGridViewTextBoxColumn.HeaderText = "Fecha Compra Enca";
            this.fechacompraencaDataGridViewTextBoxColumn.Name = "fechacompraencaDataGridViewTextBoxColumn";
            // 
            // totalcompraencaDataGridViewTextBoxColumn
            // 
            this.totalcompraencaDataGridViewTextBoxColumn.DataPropertyName = "Total_compraenca";
            this.totalcompraencaDataGridViewTextBoxColumn.HeaderText = "Total Compra Enca";
            this.totalcompraencaDataGridViewTextBoxColumn.Name = "totalcompraencaDataGridViewTextBoxColumn";
            // 
            // estatuscompraencaDataGridViewTextBoxColumn
            // 
            this.estatuscompraencaDataGridViewTextBoxColumn.DataPropertyName = "Estatus_compraenca";
            this.estatuscompraencaDataGridViewTextBoxColumn.HeaderText = "Estatus Compra Enca";
            this.estatuscompraencaDataGridViewTextBoxColumn.Name = "estatuscompraencaDataGridViewTextBoxColumn";
            // 
            // compraEncabezadoBindingSource
            // 
            this.compraEncabezadoBindingSource.DataSource = typeof(Prototipo1p.Clases.CompraEncabezado);
            // 
            // frmCompraE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(984, 504);
            this.Controls.Add(this.pnlLLenarCamposPE);
            this.Controls.Add(this.pnlBotonBuscarCE);
            this.Controls.Add(this.txtBuscarCE);
            this.Controls.Add(this.dgvCompraE);
            this.Controls.Add(this.pnlBotonGuardarCE);
            this.Controls.Add(this.pnlModificarCE);
            this.Controls.Add(this.pnlCampoApellidoEmpleado);
            this.Controls.Add(this.pnlCampoNombreEmpleado);
            this.Controls.Add(this.pnlCampoIdUsuario);
            this.Controls.Add(this.pnlCampoDpiEmpleado);
            this.Controls.Add(this.pnlCampoIDE);
            this.Controls.Add(this.picDepartamento);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.pnlCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCompraE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCompraE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDepartamento)).EndInit();
            this.pnlCampoApellidoEmpleado.ResumeLayout(false);
            this.pnlCampoApellidoEmpleado.PerformLayout();
            this.pnlCampoNombreEmpleado.ResumeLayout(false);
            this.pnlCampoNombreEmpleado.PerformLayout();
            this.pnlCampoIdUsuario.ResumeLayout(false);
            this.pnlCampoIdUsuario.PerformLayout();
            this.pnlCampoDpiEmpleado.ResumeLayout(false);
            this.pnlCampoDpiEmpleado.PerformLayout();
            this.pnlCampoIDE.ResumeLayout(false);
            this.pnlCampoIDE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompraE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compraEncabezadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCerrar;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.PictureBox picDepartamento;
        private System.Windows.Forms.Panel pnlBotonGuardarCE;
        private System.Windows.Forms.Panel pnlModificarCE;
        private System.Windows.Forms.Panel pnlCampoApellidoEmpleado;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.Label lblApellidoEmpleado;
        private System.Windows.Forms.Panel pnlCampoNombreEmpleado;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.Panel pnlCampoIdUsuario;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.Panel pnlCampoDpiEmpleado;
        private System.Windows.Forms.Label lblDpiEmpleado;
        private System.Windows.Forms.Panel pnlCampoIDE;
        private System.Windows.Forms.TextBox txtIdDoc;
        private System.Windows.Forms.Label lbnIdEmpleado;
        private System.Windows.Forms.DataGridView dgvCompraE;
        private System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.Panel pnlBotonBuscarCE;
        private System.Windows.Forms.TextBox txtBuscarCE;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentocompraencaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoproveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechacompraencaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalcompraencaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatuscompraencaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource compraEncabezadoBindingSource;
        private System.Windows.Forms.ComboBox cbxProveedor;
        private System.Windows.Forms.Panel pnlLLenarCamposPE;
    }
}