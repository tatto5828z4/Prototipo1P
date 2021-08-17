namespace Prototipo1p
{
    partial class frmCompraD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompraD));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCerrar = new System.Windows.Forms.Panel();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.picDepartamento = new System.Windows.Forms.PictureBox();
            this.pnlLLenarCamposCD = new System.Windows.Forms.Panel();
            this.pnlBotonBuscarCD = new System.Windows.Forms.Panel();
            this.txtBuscarCD = new System.Windows.Forms.TextBox();
            this.dgvCompraD = new System.Windows.Forms.DataGridView();
            this.pnlBotonGuardarCD = new System.Windows.Forms.Panel();
            this.pnlModificarCD = new System.Windows.Forms.Panel();
            this.pnlCampoApellidoEmpleado = new System.Windows.Forms.Panel();
            this.lblApellidoEmpleado = new System.Windows.Forms.Label();
            this.pnlCampoNombreEmpleado = new System.Windows.Forms.Panel();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.pnlCampoIdUsuario = new System.Windows.Forms.Panel();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.pnlCampoDpiEmpleado = new System.Windows.Forms.Panel();
            this.cbxProd = new System.Windows.Forms.ComboBox();
            this.lblDpiEmpleado = new System.Windows.Forms.Label();
            this.pnlCampoIDE = new System.Windows.Forms.Panel();
            this.lbnIdEmpleado = new System.Windows.Forms.Label();
            this.cbxEnca = new System.Windows.Forms.ComboBox();
            this.cbxIdBodega = new System.Windows.Forms.ComboBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.compraDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentocompraencaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadcompradetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costocompradetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigobodegaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picDepartamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompraD)).BeginInit();
            this.pnlCampoApellidoEmpleado.SuspendLayout();
            this.pnlCampoNombreEmpleado.SuspendLayout();
            this.pnlCampoIdUsuario.SuspendLayout();
            this.pnlCampoDpiEmpleado.SuspendLayout();
            this.pnlCampoIDE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.compraDetalleBindingSource)).BeginInit();
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
            this.pnlCerrar.TabIndex = 360;
            this.pnlCerrar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlCerrar_MouseClick);
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDepartamento.Location = new System.Drawing.Point(637, 11);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(87, 13);
            this.lblDepartamento.TabIndex = 362;
            this.lblDepartamento.Text = "Jorge Castaneda";
            // 
            // picDepartamento
            // 
            this.picDepartamento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picDepartamento.BackgroundImage")));
            this.picDepartamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picDepartamento.Location = new System.Drawing.Point(612, 7);
            this.picDepartamento.Name = "picDepartamento";
            this.picDepartamento.Size = new System.Drawing.Size(20, 21);
            this.picDepartamento.TabIndex = 361;
            this.picDepartamento.TabStop = false;
            // 
            // pnlLLenarCamposCD
            // 
            this.pnlLLenarCamposCD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLLenarCamposCD.BackgroundImage")));
            this.pnlLLenarCamposCD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlLLenarCamposCD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlLLenarCamposCD.Location = new System.Drawing.Point(856, 121);
            this.pnlLLenarCamposCD.Name = "pnlLLenarCamposCD";
            this.pnlLLenarCamposCD.Size = new System.Drawing.Size(120, 124);
            this.pnlLLenarCamposCD.TabIndex = 389;
            this.pnlLLenarCamposCD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlLLenarCamposCD_MouseClick);
            // 
            // pnlBotonBuscarCD
            // 
            this.pnlBotonBuscarCD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBotonBuscarCD.BackgroundImage")));
            this.pnlBotonBuscarCD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlBotonBuscarCD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBotonBuscarCD.Location = new System.Drawing.Point(664, 79);
            this.pnlBotonBuscarCD.Name = "pnlBotonBuscarCD";
            this.pnlBotonBuscarCD.Size = new System.Drawing.Size(22, 22);
            this.pnlBotonBuscarCD.TabIndex = 388;
            this.pnlBotonBuscarCD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlBotonBuscarCD_MouseClick);
            // 
            // txtBuscarCD
            // 
            this.txtBuscarCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarCD.Location = new System.Drawing.Point(422, 79);
            this.txtBuscarCD.Multiline = true;
            this.txtBuscarCD.Name = "txtBuscarCD";
            this.txtBuscarCD.Size = new System.Drawing.Size(221, 20);
            this.txtBuscarCD.TabIndex = 387;
            // 
            // dgvCompraD
            // 
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgvCompraD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCompraD.AutoGenerateColumns = false;
            this.dgvCompraD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(227)))));
            this.dgvCompraD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCompraD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCompraD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompraD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.documentocompraencaDataGridViewTextBoxColumn,
            this.codigoproductoDataGridViewTextBoxColumn,
            this.cantidadcompradetDataGridViewTextBoxColumn,
            this.costocompradetDataGridViewTextBoxColumn,
            this.codigobodegaDataGridViewTextBoxColumn});
            this.dgvCompraD.DataSource = this.compraDetalleBindingSource;
            this.dgvCompraD.Location = new System.Drawing.Point(314, 121);
            this.dgvCompraD.Name = "dgvCompraD";
            this.dgvCompraD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(102)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompraD.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCompraD.RowHeadersWidth = 45;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(102)))), ((int)(((byte)(107)))));
            this.dgvCompraD.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCompraD.Size = new System.Drawing.Size(547, 207);
            this.dgvCompraD.TabIndex = 386;
            this.dgvCompraD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompraD_CellContentClick);
            // 
            // pnlBotonGuardarCD
            // 
            this.pnlBotonGuardarCD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBotonGuardarCD.BackgroundImage")));
            this.pnlBotonGuardarCD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlBotonGuardarCD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBotonGuardarCD.Location = new System.Drawing.Point(153, 342);
            this.pnlBotonGuardarCD.Name = "pnlBotonGuardarCD";
            this.pnlBotonGuardarCD.Size = new System.Drawing.Size(37, 42);
            this.pnlBotonGuardarCD.TabIndex = 385;
            this.pnlBotonGuardarCD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlBotonGuardarCD_MouseClick);
            // 
            // pnlModificarCD
            // 
            this.pnlModificarCD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlModificarCD.BackgroundImage")));
            this.pnlModificarCD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlModificarCD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlModificarCD.Location = new System.Drawing.Point(203, 342);
            this.pnlModificarCD.Name = "pnlModificarCD";
            this.pnlModificarCD.Size = new System.Drawing.Size(37, 42);
            this.pnlModificarCD.TabIndex = 379;
            this.pnlModificarCD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlModificarCD_MouseClick);
            // 
            // pnlCampoApellidoEmpleado
            // 
            this.pnlCampoApellidoEmpleado.Controls.Add(this.cbxIdBodega);
            this.pnlCampoApellidoEmpleado.Controls.Add(this.lblApellidoEmpleado);
            this.pnlCampoApellidoEmpleado.Location = new System.Drawing.Point(72, 288);
            this.pnlCampoApellidoEmpleado.Name = "pnlCampoApellidoEmpleado";
            this.pnlCampoApellidoEmpleado.Size = new System.Drawing.Size(212, 48);
            this.pnlCampoApellidoEmpleado.TabIndex = 382;
            // 
            // lblApellidoEmpleado
            // 
            this.lblApellidoEmpleado.AutoSize = true;
            this.lblApellidoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoEmpleado.Location = new System.Drawing.Point(3, 9);
            this.lblApellidoEmpleado.Name = "lblApellidoEmpleado";
            this.lblApellidoEmpleado.Size = new System.Drawing.Size(67, 13);
            this.lblApellidoEmpleado.TabIndex = 10;
            this.lblApellidoEmpleado.Text = "ID Bodega";
            // 
            // pnlCampoNombreEmpleado
            // 
            this.pnlCampoNombreEmpleado.Controls.Add(this.txtCosto);
            this.pnlCampoNombreEmpleado.Controls.Add(this.lblNombreEmpleado);
            this.pnlCampoNombreEmpleado.Location = new System.Drawing.Point(71, 234);
            this.pnlCampoNombreEmpleado.Name = "pnlCampoNombreEmpleado";
            this.pnlCampoNombreEmpleado.Size = new System.Drawing.Size(212, 48);
            this.pnlCampoNombreEmpleado.TabIndex = 384;
            // 
            // txtCosto
            // 
            this.txtCosto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCosto.Location = new System.Drawing.Point(3, 27);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(205, 13);
            this.txtCosto.TabIndex = 11;
            this.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpleado.Location = new System.Drawing.Point(3, 9);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(129, 13);
            this.lblNombreEmpleado.TabIndex = 10;
            this.lblNombreEmpleado.Text = "Costo Compra Detalle";
            // 
            // pnlCampoIdUsuario
            // 
            this.pnlCampoIdUsuario.Controls.Add(this.txtcantidad);
            this.pnlCampoIdUsuario.Controls.Add(this.lblIdUsuario);
            this.pnlCampoIdUsuario.Location = new System.Drawing.Point(70, 178);
            this.pnlCampoIdUsuario.Name = "pnlCampoIdUsuario";
            this.pnlCampoIdUsuario.Size = new System.Drawing.Size(212, 48);
            this.pnlCampoIdUsuario.TabIndex = 383;
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdUsuario.Location = new System.Drawing.Point(3, 9);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(147, 13);
            this.lblIdUsuario.TabIndex = 10;
            this.lblIdUsuario.Text = "Cantidad Compra Detalle";
            // 
            // pnlCampoDpiEmpleado
            // 
            this.pnlCampoDpiEmpleado.Controls.Add(this.cbxProd);
            this.pnlCampoDpiEmpleado.Controls.Add(this.lblDpiEmpleado);
            this.pnlCampoDpiEmpleado.Location = new System.Drawing.Point(70, 121);
            this.pnlCampoDpiEmpleado.Name = "pnlCampoDpiEmpleado";
            this.pnlCampoDpiEmpleado.Size = new System.Drawing.Size(212, 48);
            this.pnlCampoDpiEmpleado.TabIndex = 381;
            // 
            // cbxProd
            // 
            this.cbxProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProd.FormattingEnabled = true;
            this.cbxProd.Location = new System.Drawing.Point(2, 24);
            this.cbxProd.Name = "cbxProd";
            this.cbxProd.Size = new System.Drawing.Size(205, 21);
            this.cbxProd.TabIndex = 36;
            // 
            // lblDpiEmpleado
            // 
            this.lblDpiEmpleado.AutoSize = true;
            this.lblDpiEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDpiEmpleado.Location = new System.Drawing.Point(3, 9);
            this.lblDpiEmpleado.Name = "lblDpiEmpleado";
            this.lblDpiEmpleado.Size = new System.Drawing.Size(75, 13);
            this.lblDpiEmpleado.TabIndex = 10;
            this.lblDpiEmpleado.Text = "ID Producto";
            // 
            // pnlCampoIDE
            // 
            this.pnlCampoIDE.Controls.Add(this.cbxEnca);
            this.pnlCampoIDE.Controls.Add(this.lbnIdEmpleado);
            this.pnlCampoIDE.Location = new System.Drawing.Point(69, 58);
            this.pnlCampoIDE.Name = "pnlCampoIDE";
            this.pnlCampoIDE.Size = new System.Drawing.Size(212, 48);
            this.pnlCampoIDE.TabIndex = 380;
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
            // cbxEnca
            // 
            this.cbxEnca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEnca.FormattingEnabled = true;
            this.cbxEnca.Location = new System.Drawing.Point(4, 25);
            this.cbxEnca.Name = "cbxEnca";
            this.cbxEnca.Size = new System.Drawing.Size(205, 21);
            this.cbxEnca.TabIndex = 37;
            // 
            // cbxIdBodega
            // 
            this.cbxIdBodega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIdBodega.FormattingEnabled = true;
            this.cbxIdBodega.Location = new System.Drawing.Point(3, 24);
            this.cbxIdBodega.Name = "cbxIdBodega";
            this.cbxIdBodega.Size = new System.Drawing.Size(205, 21);
            this.cbxIdBodega.TabIndex = 38;
            // 
            // txtcantidad
            // 
            this.txtcantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcantidad.Location = new System.Drawing.Point(3, 28);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(205, 13);
            this.txtcantidad.TabIndex = 12;
            this.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // compraDetalleBindingSource
            // 
            this.compraDetalleBindingSource.DataSource = typeof(Prototipo1p.Clases.CompraDetalle);
            // 
            // documentocompraencaDataGridViewTextBoxColumn
            // 
            this.documentocompraencaDataGridViewTextBoxColumn.DataPropertyName = "Documento_compraenca";
            this.documentocompraencaDataGridViewTextBoxColumn.HeaderText = "Documento_compraenca";
            this.documentocompraencaDataGridViewTextBoxColumn.Name = "documentocompraencaDataGridViewTextBoxColumn";
            // 
            // codigoproductoDataGridViewTextBoxColumn
            // 
            this.codigoproductoDataGridViewTextBoxColumn.DataPropertyName = "Codigo_producto";
            this.codigoproductoDataGridViewTextBoxColumn.HeaderText = "Codigo_producto";
            this.codigoproductoDataGridViewTextBoxColumn.Name = "codigoproductoDataGridViewTextBoxColumn";
            // 
            // cantidadcompradetDataGridViewTextBoxColumn
            // 
            this.cantidadcompradetDataGridViewTextBoxColumn.DataPropertyName = "Cantidad_compradet";
            this.cantidadcompradetDataGridViewTextBoxColumn.HeaderText = "Cantidad_compradet";
            this.cantidadcompradetDataGridViewTextBoxColumn.Name = "cantidadcompradetDataGridViewTextBoxColumn";
            // 
            // costocompradetDataGridViewTextBoxColumn
            // 
            this.costocompradetDataGridViewTextBoxColumn.DataPropertyName = "Costo_compradet";
            this.costocompradetDataGridViewTextBoxColumn.HeaderText = "Costo_compradet";
            this.costocompradetDataGridViewTextBoxColumn.Name = "costocompradetDataGridViewTextBoxColumn";
            // 
            // codigobodegaDataGridViewTextBoxColumn
            // 
            this.codigobodegaDataGridViewTextBoxColumn.DataPropertyName = "Codigo_bodega";
            this.codigobodegaDataGridViewTextBoxColumn.HeaderText = "Codigo_bodega";
            this.codigobodegaDataGridViewTextBoxColumn.Name = "codigobodegaDataGridViewTextBoxColumn";
            // 
            // frmCompraD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(984, 504);
            this.Controls.Add(this.pnlLLenarCamposCD);
            this.Controls.Add(this.pnlBotonBuscarCD);
            this.Controls.Add(this.txtBuscarCD);
            this.Controls.Add(this.dgvCompraD);
            this.Controls.Add(this.pnlBotonGuardarCD);
            this.Controls.Add(this.pnlModificarCD);
            this.Controls.Add(this.pnlCampoApellidoEmpleado);
            this.Controls.Add(this.pnlCampoNombreEmpleado);
            this.Controls.Add(this.pnlCampoIdUsuario);
            this.Controls.Add(this.pnlCampoDpiEmpleado);
            this.Controls.Add(this.pnlCampoIDE);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.picDepartamento);
            this.Controls.Add(this.pnlCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCompraD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCompraD";
            ((System.ComponentModel.ISupportInitialize)(this.picDepartamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompraD)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.compraDetalleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCerrar;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.PictureBox picDepartamento;
        private System.Windows.Forms.Panel pnlLLenarCamposCD;
        private System.Windows.Forms.Panel pnlBotonBuscarCD;
        private System.Windows.Forms.TextBox txtBuscarCD;
        private System.Windows.Forms.DataGridView dgvCompraD;
        private System.Windows.Forms.Panel pnlBotonGuardarCD;
        private System.Windows.Forms.Panel pnlModificarCD;
        private System.Windows.Forms.Panel pnlCampoApellidoEmpleado;
        private System.Windows.Forms.ComboBox cbxIdBodega;
        private System.Windows.Forms.Label lblApellidoEmpleado;
        private System.Windows.Forms.Panel pnlCampoNombreEmpleado;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.Panel pnlCampoIdUsuario;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.Panel pnlCampoDpiEmpleado;
        private System.Windows.Forms.ComboBox cbxProd;
        private System.Windows.Forms.Label lblDpiEmpleado;
        private System.Windows.Forms.Panel pnlCampoIDE;
        private System.Windows.Forms.ComboBox cbxEnca;
        private System.Windows.Forms.Label lbnIdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentocompraencaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadcompradetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costocompradetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigobodegaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource compraDetalleBindingSource;
    }
}