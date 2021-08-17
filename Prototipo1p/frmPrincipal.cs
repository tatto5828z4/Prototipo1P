using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo1p
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void pnlCerrar_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnPuesto_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCliente_MouseClick(object sender, MouseEventArgs e)
        {
            frmCompraE obj = new frmCompraE();
            obj.Visible = true;
            Visible = false;
        }

        private void btnPuesto_MouseClick(object sender, MouseEventArgs e)
        {
            frmCompraD obj = new frmCompraD();
            obj.Visible = true;
            Visible = false;
        }
    }
}
