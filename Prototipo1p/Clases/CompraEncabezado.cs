using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo1p.Clases
{
    public class CompraEncabezado
    {
        String documento_compraenca;
        String codigo_proveedor;
        String fecha_compraenca;
        String total_compraenca;
        String estatus_compraenca;

        public CompraEncabezado(string documento_compraenca, string codigo_proveedor, string fecha_compraenca, string total_compraenca, string estatus_compraenca)
        {
            this.documento_compraenca = documento_compraenca;
            this.codigo_proveedor = codigo_proveedor;
            this.fecha_compraenca = fecha_compraenca;
            this.total_compraenca = total_compraenca;
            this.estatus_compraenca = estatus_compraenca;
        }

        public string Documento_compraenca { get => documento_compraenca; set => documento_compraenca = value; }
        public string Codigo_proveedor { get => codigo_proveedor; set => codigo_proveedor = value; }
        public string Fecha_compraenca { get => fecha_compraenca; set => fecha_compraenca = value; }
        public string Total_compraenca { get => total_compraenca; set => total_compraenca = value; }
        public string Estatus_compraenca { get => estatus_compraenca; set => estatus_compraenca = value; }

        public CompraEncabezado()
        {

        }

        public void funInsertar()
        {
            String psql = "INSERT INTO compras_encabezado(documento_compraenca,codigo_proveedor,fecha_compraenca,total_compraenca,estatus_compraenca)" +
                " VALUES ('" + documento_compraenca + "' , '" + codigo_proveedor + "' , '" + fecha_compraenca + "' , '"
                + total_compraenca + "' , '" + estatus_compraenca + "')";

            //Console.WriteLine(psql);
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand insertarPE = new MySqlCommand(psql, conexionBD);
                insertarPE.ExecuteNonQuery();
                MessageBox.Show("Datos Ingresados Correctamente");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar los datos " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        public void cargarCombobox(ComboBox combobox, String tabla, String id, String nombre)
        {
            combobox.DataSource = null;
            combobox.Items.Clear();

            String sql = "SELECT * FROM " + tabla;
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand cargarCombobox = new MySqlCommand(sql, conexionBD);
                /*Guarda la consulta en este objeto*/
                MySqlDataAdapter data = new MySqlDataAdapter(cargarCombobox);
                DataTable dt = new DataTable();
                /*Los datos de una consulta los agregamos a un combobox*/
                data.Fill(dt);

                combobox.ValueMember = id;
                combobox.DisplayMember = nombre;
                /*Se llena el combobox*/
                combobox.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar datos del combobox " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        public List<Object> consulta(String dato)
        {
            MySqlDataReader reader = null;
            List<Object> lista = new List<Object>();
            String sql;

            if (dato == null)
            {
                sql = "SELECT * FROM compras_encabezado";
            }
            else
            {
                sql = "SELECT * FROM compras_encabezado WHERE documento_compraenca LIKE '%" + dato + "%'";
            }

            try
            {
                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();

                MySqlCommand buscarPaqueteE = new MySqlCommand(sql, conexionBD);
                reader = buscarPaqueteE.ExecuteReader();


                while (reader.Read())
                {

                    CompraEncabezado compraE = new CompraEncabezado();

                    compraE.documento_compraenca = reader.GetString("documento_compraenca");
                    compraE.codigo_proveedor = reader.GetString("codigo_proveedor");

                    compraE.fecha_compraenca = reader.GetString("fecha_compraenca");
                    compraE.total_compraenca = reader.GetString("total_compraenca");
                    compraE.estatus_compraenca = reader.GetString("estatus_compraenca");
                    

                    lista.Add(compraE);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            return lista;

        }

        public void obtenerNombre(String codigo)
        {
            MySqlDataReader leer = null;
            String pSqlBuscar = "SELECT nombre_proveedor from proveedores WHERE codigo_proveedor='" + codigo + "'";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand buscar = new MySqlCommand(pSqlBuscar, conexionBD);
                leer = buscar.ExecuteReader();

                while (leer.Read())
                {
                    codigo = leer.GetString("nombre_proveedor");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar los datos " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }

        }

        public void funModificar(String idModificar)
        {
            //Console.WriteLine(IdDepartamentoEmpleado);
            String pSqlModificar = "UPDATE compras_encabezado SET codigo_proveedor='" + codigo_proveedor + "', fecha_compraenca='" + fecha_compraenca + "', total_compraenca='" + total_compraenca + "', estatus_compraenca='" + estatus_compraenca + "' WHERE documento_compraenca='" + idModificar + "'";
            //Console.WriteLine(pSqlModificar);
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand modificarEmpleado = new MySqlCommand(pSqlModificar, conexionBD);
                modificarEmpleado.ExecuteNonQuery();
                MessageBox.Show("Datos Modificados Correctamente");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al modificar los datos " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        public void funBuscarSetearTxt(TextBox doc, ComboBox cod, DateTimePicker fecha, TextBox total, TextBox estatus)
        {
            MySqlDataReader leer = null;

            String pSqlBuscar = "SELECT * from compras_encabezado WHERE documento_compraenca='" + documento_compraenca + "'";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand busqueda = new MySqlCommand(pSqlBuscar, conexionBD);
                leer = busqueda.ExecuteReader();

                while (leer.Read())
                {
                    doc.Text = leer.GetString(0);
                    cod.Text = leer.GetString(1);
                    fecha.Text = leer.GetString(2);
                    total.Text = leer.GetString(3);
                    estatus.Text = leer.GetString(4);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar los datos " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }
    }
}
