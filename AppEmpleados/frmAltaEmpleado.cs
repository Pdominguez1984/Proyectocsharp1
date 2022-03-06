using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEmpleados
{
    public partial class frmAltaEmpleado : Form
    {
        private Empleado empleadoModificado = null;
        private void mensajeCatch()
        {
            string error = "Se ha producido un error inesperado xd";
            MessageBox.Show(error);
        }
        private void CargarEmpleado()
        {
            try
            {
                EmpleadoConexion conexion = new EmpleadoConexion();
                Empleado nuevoEmpleado = new Empleado();
                nuevoEmpleado.NombreCompleto = txtNombreEmpleado.Text.Trim().ToUpper();
                nuevoEmpleado.Documento = double.Parse(txtDniEmpleado.Text.Trim());
                nuevoEmpleado.Edad = int.Parse(txtEdad.Text.Trim());
                int auxcasado = 0;
                if (chbCasado.Checked)
                {
                    auxcasado = 1;
                }

                nuevoEmpleado.Casado = auxcasado;
                nuevoEmpleado.Salario = decimal.Parse(txtSueldo.Text.Trim());
                conexion.AltaEmpleado(nuevoEmpleado);
                MessageBox.Show("Nuevo Empleado agregado con exito a la base de datos");
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ModificarDatosEmpleado()
        {
            try
            {
                EmpleadoConexion conexion = new EmpleadoConexion();
                Empleado modifEmpleado = new Empleado();
                modifEmpleado.idEmpleado = empleadoModificado.idEmpleado;
                modifEmpleado.NombreCompleto = txtNombreEmpleado.Text.Trim().ToUpper();
                modifEmpleado.Documento = double.Parse(txtDniEmpleado.Text.Trim());
                modifEmpleado.Edad = int.Parse(txtEdad.Text.Trim());
                int auxcasado = 0;
                if (chbCasado.Checked)
                {
                    auxcasado = 1;
                }
                modifEmpleado.Casado = auxcasado;
                modifEmpleado.Salario = decimal.Parse(txtSueldo.Text.Trim());
                conexion.ModificarEmpleado(modifEmpleado);
                MessageBox.Show("Se modificaron con exito los datos del empleado");
            }
            catch (Exception ex)
            {
                mensajeCatch();

                throw;
            }
        }
        private void CerrarVentana()
        {
            this.Close();
        }
        private void LimpiarCajasTexto()
        {
            txtDniEmpleado.Clear();
            txtEdad.Clear();
            txtSueldo.Clear();
            chbCasado.Checked = false;
            txtNombreEmpleado.Clear();
        
        }
        private void pasarDatosEmpleadoModificar()
        {
            try
            {
                int idModificacion = empleadoModificado.idEmpleado;
                txtNombreEmpleado.Text = empleadoModificado.NombreCompleto;
                txtEdad.Text = Convert.ToString(empleadoModificado.Edad);
                txtSueldo.Text = Convert.ToString(empleadoModificado.Salario);
                txtDniEmpleado.Text = Convert.ToString(empleadoModificado.Documento);
                if (empleadoModificado.Casado == 1)
                {
                    chbCasado.Checked = true;
                }
                else
                {
                    chbCasado.Checked = false;
                }
            }
            catch (Exception ex )
            {
                mensajeCatch();
                throw;
            }
            
        }
        public frmAltaEmpleado()
        {
            InitializeComponent();
        }
        //sobrecarga del constructor para modificacion le paso un empleado cargado de la grilla
        public frmAltaEmpleado(Empleado empleadoModificado)
        {
            InitializeComponent();
            this.empleadoModificado = empleadoModificado;
        }

        private void frmAltaEmpleado_Load(object sender, EventArgs e)
        {
            //VERIFICO : si empleado.datos es distinto de null significa que pase datos para modificar.
            //si es null se trata de alta
            if (empleadoModificado!=null)
            {
                pasarDatosEmpleadoModificar();
            }
            
        }

        private void btnCancelarCargaEmpleado_Click(object sender, EventArgs e)
        {

            CerrarVentana();
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            if (empleadoModificado!=null)
            {
                //modificar
                ModificarDatosEmpleado();
            }
            else
            {
                //alta
                CargarEmpleado();
            }
            
            LimpiarCajasTexto();
        }
    }
}
