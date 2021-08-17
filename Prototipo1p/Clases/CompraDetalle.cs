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
    public class CompraDetalle
    {
        String documento_compraenca;
        String codigo_producto;
        String cantidad_compradet;
        String costo_compradet;
        String codigo_bodega;

        public CompraDetalle(string documento_compraenca, string codigo_producto, string cantidad_compradet, string costo_compradet, string codigo_bodega)
        {
            this.documento_compraenca = documento_compraenca;
            this.codigo_producto = codigo_producto;
            this.cantidad_compradet = cantidad_compradet;
            this.costo_compradet = costo_compradet;
            this.codigo_bodega = codigo_bodega;
        }

        public CompraDetalle()
        {

        }

        public string Documento_compraenca { get => documento_compraenca; set => documento_compraenca = value; }
        public string Codigo_producto { get => codigo_producto; set => codigo_producto = value; }
        public string Cantidad_compradet { get => cantidad_compradet; set => cantidad_compradet = value; }
        public string Costo_compradet { get => costo_compradet; set => costo_compradet = value; }
        public string Codigo_bodega { get => codigo_bodega; set => codigo_bodega = value; }

        public void funInsertar()
        {
            String psql = "INSERT INTO compras_detalle(documento_compraenca,codigo_producto,cantidad_compradet,costo_compradet,codigo_bodega)" +
                " VALUES ('" + Documento_compraenca + "' , '" + Codigo_producto + "' , '" + Cantidad_compradet + "' , '"
                + Costo_compradet + "' , '" + Codigo_bodega + "')";

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
                sql = "SELECT * FROM compras_detalle";
            }
            else
            {
                sql = "SELECT * FROM compras_detalle WHERE documento_compraenca LIKE '%" + dato + "%'";
            }

            try
            {
                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();

                MySqlCommand buscarPaqueteE = new MySqlCommand(sql, conexionBD);
                reader = buscarPaqueteE.ExecuteReader();


                while (reader.Read())
                {
                    CompraDetalle compraD = new CompraDetalle();

                    compraD.documento_compraenca = reader.GetString("documento_compraenca");
                    compraD.codigo_producto = reader.GetString("codigo_producto");

                    compraD.cantidad_compradet = reader.GetString("cantidad_compradet");
                    compraD.costo_compradet = reader.GetString("costo_compradet");
                    compraD.codigo_bodega = reader.GetString("codigo_bodega");


                    lista.Add(compraD);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            return lista;

        }

        // obtener nombre de producto
        public void obtenerNombre(String codigo)
        {
            MySqlDataReader leer = null;
            String pSqlBuscar = "SELECT nombre_producto from productos WHERE codigo_producto='" + codigo + "'";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand buscar = new MySqlCommand(pSqlBuscar, conexionBD);
                leer = buscar.ExecuteReader();

                while (leer.Read())
                {
                    codigo = leer.GetString("nombre_producto");
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

        // obtener nombre de bodega
        public void obtenerNombreBod(String codigo)
        {
            MySqlDataReader leer = null;
            String pSqlBuscar = "SELECT nombre_bodega from bodegas WHERE codigo_bodega='" + codigo + "'";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand buscar = new MySqlCommand(pSqlBuscar, conexionBD);
                leer = buscar.ExecuteReader();

                while (leer.Read())
                {
                    codigo = leer.GetString("nombre_bodega");
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
            String pSqlModificar = "UPDATE compras_detalle SET codigo_producto='" + codigo_producto + "', cantidad_compradet='" + cantidad_compradet + "', costo_compradet='" + costo_compradet + "', codigo_bodega='" + codigo_bodega + "' WHERE documento_compraenca='" + idModificar + "'";
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

        public void funBuscarSetearTxt(ComboBox doc, ComboBox cod, TextBox cant, TextBox costo, ComboBox bodega)
        {
            MySqlDataReader leer = null;

            String pSqlBuscar = "SELECT * from compras_detalle WHERE documento_compraenca='" + documento_compraenca + "'";

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
                    cant.Text = leer.GetString(2);
                    costo.Text = leer.GetString(3);
                    bodega.Text = leer.GetString(4);
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
