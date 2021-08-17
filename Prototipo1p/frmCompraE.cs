using Prototipo1p.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Prototipo1p
{
    public partial class frmCompraE : Form
    {
        /* Codigo para redondear mi panel */
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
            );

        /* Codigo para mover mi panel */
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public frmCompraE()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            CompraEncabezado enc = new CompraEncabezado();
            enc.cargarCombobox(cbxProveedor,"proveedores", "codigo_proveedor", "nombre_proveedor");
            funCargarTabla(null);
           

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

        private void txtFechaRecPE_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pnlBotonGuardarCE_MouseClick(object sender, MouseEventArgs e)
        {
            //String estatusPaqEncabezado = "A";
            CompraEncabezado compraEncabezado = funObtenerTxt();
            compraEncabezado.funInsertar();
            /* Final de ejecucion de funcion insertar un cliente */

            funCargarTabla(null);
            funVaciarCampos();
        }

        public CompraEncabezado funObtenerTxt()
        {
            /*Inicio obteniedo variables a usar con mi ABC cliente */
            String doc = txtIdDoc.Text;
            String cod = cbxProveedor.SelectedValue.ToString();
            String fecha = txtFecha.Value.ToString("yyyy-MM-dd");
            String total = txtTotal.Text;
            String estatus = txtEstatus.Text;
            /*Final obteniedo variables a usar con mi ABC */

            /* Inicio creamos un objeto de tipo paqueteEncabezado para poder utilizar el metodo de insertar */
            CompraEncabezado compraE = new CompraEncabezado(doc, cod, fecha, total, estatus);
            /* Final creamos un objeto de tipo cliente para poder utilizar el metodo de insertar cliente */

            return compraE;
        }

        private void frmCompraE_Load(object sender, EventArgs e)
        {

        }

        private void funCargarTabla(string dato)
        {
            List<CompraEncabezado> lista = new List<CompraEncabezado>();
            CompraEncabezado compraE = new CompraEncabezado();

            dgvCompraE.DataSource = compraE.consulta(dato);
        }

        public void funVaciarCampos()
        {
            txtIdDoc.Text = "";
            cbxProveedor.SelectedValue = "";
            txtTotal.Text = "";
            txtEstatus.Text = "";
        }

        private void pnlModificarCE_MouseClick(object sender, MouseEventArgs e)
        {
            String idcomprae = txtIdDoc.Text;
            CompraEncabezado compraE = funObtenerTxt();

            compraE.funModificar(idcomprae);
            funCargarTabla(null);

            compraE.funBuscarSetearTxt(txtIdDoc, cbxProveedor, txtFecha, txtTotal, txtEstatus);

        }

        private void pnlBotonBuscarCE_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio buscando el dato ingresado por el usuario y llenando mi tabla */
            String buscarPE = txtBuscarCE.Text;
            funCargarTabla(buscarPE);
            /* Final buscando el dato ingresado por el usuario y llenando mi tabla */

            /* Inicio Vaciando los campos */
            funVaciarCampos();
            /* Final Vaciando los campos */
        }

        private void pnlLLenarCamposPE_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdDoc.Text = dgvCompraE.CurrentRow.Cells[0].Value.ToString();

            String idProveedor = dgvCompraE.CurrentRow.Cells[1].Value.ToString();

            CompraEncabezado compraE = new CompraEncabezado();
            compraE.obtenerNombre(idProveedor);
            //en la funcion idCliente se le asigna el nombre que existe en la BD y se le coloca al combobox
            cbxProveedor.SelectedValue = idProveedor;

            // De string a dateTime
            txtFecha.Value = Convert.ToDateTime(dgvCompraE.CurrentRow.Cells[2].Value.ToString());
            txtTotal.Text = dgvCompraE.CurrentRow.Cells[3].Value.ToString();
            txtEstatus.Text = dgvCompraE.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
