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

namespace Prototipo1p
{
    public partial class frmCompraD : Form
    {
        public frmCompraD()
        {
            InitializeComponent();
            CompraDetalle det = new CompraDetalle();
            det.cargarCombobox(cbxEnca, "compras_encabezado", "documento_compraenca", "documento_compraenca");
            det.cargarCombobox(cbxProd, "productos", "codigo_producto", "nombre_producto");
            det.cargarCombobox(cbxIdBodega, "bodegas", "codigo_bodega", "nombre_bodega");
            funCargarTabla(null);


        }

        private void btnUbicacion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlCerrar_MouseClick(object sender, MouseEventArgs e)
        {
            frmPrincipal obj = new frmPrincipal();
            obj.Visible = true;
            Visible = false;
        }

        private void pnlBotonGuardarCD_MouseClick(object sender, MouseEventArgs e)
        {
            //String estatusPaqEncabezado = "A";
            CompraDetalle compraDetalle = funObtenerTxt();
            compraDetalle.funInsertar();
            /* Final de ejecucion de funcion insertar un cliente */

            funCargarTabla(null);
            funVaciarCampos();
        }

        private void pnlModificarCD_MouseClick(object sender, MouseEventArgs e)
        {
            String idcomprae = cbxEnca.SelectedValue.ToString();
            CompraDetalle compraDetalle = funObtenerTxt();

            compraDetalle.funModificar(idcomprae);
            funCargarTabla(null);

            compraDetalle.funBuscarSetearTxt(cbxEnca, cbxProd, txtcantidad, txtCosto, cbxIdBodega);
        }

        private void pnlLLenarCamposCD_MouseClick(object sender, MouseEventArgs e)
        {
            CompraDetalle compra = new CompraDetalle();

            cbxEnca.SelectedValue = dgvCompraD.CurrentRow.Cells[0].Value.ToString();


            String producto = dgvCompraD.CurrentRow.Cells[1].Value.ToString();
            compra.obtenerNombre(producto);
            cbxProd.SelectedValue = producto;

            txtcantidad.Text = dgvCompraD.CurrentRow.Cells[2].Value.ToString();
            txtCosto.Text= dgvCompraD.CurrentRow.Cells[3].Value.ToString();

            String bodega = dgvCompraD.CurrentRow.Cells[4].Value.ToString();
            compra.obtenerNombreBod(bodega);
            cbxIdBodega.SelectedValue = bodega;
        }

        private void dgvCompraD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlBotonBuscarCD_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio buscando el dato ingresado por el usuario y llenando mi tabla */
            String buscarCD = txtBuscarCD.Text;
            funCargarTabla(buscarCD);
            /* Final buscando el dato ingresado por el usuario y llenando mi tabla */

            /* Inicio Vaciando los campos */
            funVaciarCampos();
            /* Final Vaciando los campos */
        }

        private void funCargarTabla(string dato)
        {
            List<CompraDetalle> lista = new List<CompraDetalle>();
            CompraDetalle compraD = new CompraDetalle();

            dgvCompraD.DataSource = compraD.consulta(dato);
        }

        public void funVaciarCampos()
        {
            cbxEnca.SelectedValue = "";
            cbxProd.SelectedValue = "";
            txtcantidad.Text = "";
            txtCosto.Text = "";
            cbxIdBodega.SelectedValue = "";
        }


        public CompraDetalle funObtenerTxt()
        {
            /*Inicio obteniedo variables a usar con mi ABC cliente */
            String doc = cbxEnca.SelectedValue.ToString();
            String cod = cbxProd.SelectedValue.ToString();
            String cant = txtcantidad.Text;
            String costo = txtCosto.Text;
            String codigo = cbxIdBodega.SelectedValue.ToString();
            /*Final obteniedo variables a usar con mi ABC */

            /* Inicio creamos un objeto de tipo paqueteEncabezado para poder utilizar el metodo de insertar */
            CompraDetalle compraD = new CompraDetalle(doc, cod, cant, costo, codigo);
            /* Final creamos un objeto de tipo cliente para poder utilizar el metodo de insertar cliente */

            return compraD;
        }

    }
}
