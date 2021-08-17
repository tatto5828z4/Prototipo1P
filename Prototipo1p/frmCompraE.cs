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
    public partial class frmCompraE : Form
    {
        public frmCompraE()
        {
            InitializeComponent();
        }

        private void pnlCerrar_MouseClick(object sender, MouseEventArgs e)
        {
            frmPrincipal obj = new frmPrincipal();
            obj.Visible = true;
            Visible = false;
        }

        private void pnlCerrar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
