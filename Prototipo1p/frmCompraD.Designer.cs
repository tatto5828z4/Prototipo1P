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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompraD));
            this.pnlCerrar = new System.Windows.Forms.Panel();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.picDepartamento = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDepartamento)).BeginInit();
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
            // frmCompraD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.picDepartamento);
            this.Controls.Add(this.pnlCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCompraD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCompraD";
            ((System.ComponentModel.ISupportInitialize)(this.picDepartamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlCerrar;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.PictureBox picDepartamento;
    }
}