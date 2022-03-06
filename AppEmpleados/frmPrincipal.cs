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
    public partial class frmPrincipal : Form
    {
        private void mensaje()
        {
            string error = "Se ha producido un error inesperado xd";
            MessageBox.Show(error);
        }
        private void actualizarGrilla()
        {
            try
            {

                EmpleadoConexion conexion = new EmpleadoConexion();
                ListaEmpleados = conexion.cargarGrilla();
                dgvEmpleados.DataSource = ListaEmpleados;
                dgvEmpleados.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                mensaje();
                throw;
            }
            
        }
        private List<Empleado> ListaEmpleados;  
        private void eliminarEmpleadoGrilla()
        {

            try
            {
                EmpleadoConexion conexion = new EmpleadoConexion();
                Empleado empleadoEliminado = new Empleado();
                empleadoEliminado.idEmpleado = int.Parse(dgvEmpleados.CurrentRow.Cells[0].Value.ToString());
                conexion.BorrarEmpleado(empleadoEliminado);
                MessageBox.Show("Se ha quitado con exito a al empleado seleccionado de la base de datos");
            }
            catch (Exception)
            {
                mensaje();
                throw;
            }
        }
        private void filtrado()
        {
            List<Empleado> listaFiltrada;
            string filtro = txtFiltro.Text;

            try//si el filtro es mayor a 3 caracteres cargo el dgv con la lista filtrada
               //si es vacio cargo el dgv con la lista original de bd
            {
                if (filtro.Length>=3)
                {
                listaFiltrada = ListaEmpleados.FindAll(x => x.NombreCompleto.ToUpper().Contains(filtro.ToUpper()));
                    dgvEmpleados.DataSource = null;
                    dgvEmpleados.DataSource = listaFiltrada;
                    dgvEmpleados.Columns[0].Visible = false;
                }
                else
                {
                    dgvEmpleados.DataSource = null;
                    dgvEmpleados.DataSource = ListaEmpleados;
                    dgvEmpleados.Columns[0].Visible = false;

                }


            }
            catch (Exception ex)
            {
                mensaje();
                throw;
            }

        }
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void salir()
        {
            Close();
        }
        private void btnEmpSalir_Click(object sender, EventArgs e)
        {
            salir();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaEmpleado altaEmpledo = new frmAltaEmpleado();
            altaEmpledo.ShowDialog();
            actualizarGrilla();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            actualizarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Empleado empSeleccionado =(Empleado)dgvEmpleados.CurrentRow.DataBoundItem;
            frmAltaEmpleado frmModificacion = new frmAltaEmpleado(empSeleccionado);
            frmModificacion.Text = "Empleado : Modificar Datos";
            frmModificacion.ShowDialog();
            actualizarGrilla();
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarEmpleadoGrilla();
            actualizarGrilla();
        }

        private void btnBuscarEmpleados_Click(object sender, EventArgs e)
        {
            filtrado();
        }

        private void txtFiltroEmpleados_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtrado();
        }
    }
}
