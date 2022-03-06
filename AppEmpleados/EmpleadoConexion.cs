using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace AppEmpleados
{
    internal class EmpleadoConexion
    {
        //carga grilla
        public List<Empleado> cargarGrilla()
        {
            try
            {
                List<Empleado> listaEmpleados = new List<Empleado>();
                SqlConnection conexion = new SqlConnection();
                SqlCommand comando = new SqlCommand();
                SqlDataReader lector;

                conexion.ConnectionString = "data source=DESKTOP-GTV9NNB\\SQLEXPRESS; initial catalog=EMPLEADOS_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select * from dbo.Empleados";
                comando.Connection = conexion;
                conexion.Open();

                lector = comando.ExecuteReader();
                while (lector.Read())
                {
                    Empleado xEmpleado = new Empleado();
                    xEmpleado.idEmpleado = lector.GetInt32(0);
                    xEmpleado.NombreCompleto = lector.GetString(1);
                    xEmpleado.Documento = double.Parse(lector.GetString(2));
                    xEmpleado.Edad = lector.GetInt32(3);
                    xEmpleado.Casado = Convert.ToInt32(lector.GetBoolean(4));
                    xEmpleado.Salario = lector.GetDecimal(5);

                    listaEmpleados.Add(xEmpleado);
                }
                conexion.Close();

                return listaEmpleados;
            }
            catch (Exception)
            {

                throw;
            }
        }

        
        public List<Empleado> ConsultarEmpleadoxDni()
        {
            List<Empleado> empleadoConsultado = new List<Empleado>();
            return empleadoConsultado;
        }
        //alta ok
        public void AltaEmpleado(Empleado nuevoEmpleado)
        {
            try
            {
                SqlConnection conexion = new SqlConnection();
                SqlCommand comando = new SqlCommand();
                conexion.ConnectionString = "data source=DESKTOP-GTV9NNB\\SQLEXPRESS; initial catalog=EMPLEADOS_DB; integrated security=sspi";
                comando.Connection = conexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "insert into dbo.Empleados (NombreCompleto,DNI,Edad,Casado" +
                ",Salario)values('" + nuevoEmpleado.NombreCompleto + "','" + nuevoEmpleado.Documento + "'," +
                "'" + nuevoEmpleado.Edad + "','" + nuevoEmpleado.Casado + "','" + nuevoEmpleado.Salario + "')";

                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }

        }
        //baja ok
        public void BorrarEmpleado(Empleado empleadoEliminado)
        {
            try
            {
                SqlConnection conexion = new SqlConnection();
                SqlCommand comando = new SqlCommand();
                conexion.ConnectionString = "data source=DESKTOP-GTV9NNB\\SQLEXPRESS; initial catalog=EMPLEADOS_DB; integrated security=sspi";
                comando.Connection = conexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "delete from dbo.Empleados where Id='" + empleadoEliminado.idEmpleado + "'";
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception )
            {
               
                throw;
            }
        }
        
        //modificacion
        public void ModificarEmpleado(Empleado empleadoModificado)
        {
            try
            {
                SqlConnection conexion = new SqlConnection();
                SqlCommand comando = new SqlCommand();
                conexion.ConnectionString = "data source=DESKTOP-GTV9NNB\\SQLEXPRESS; initial catalog=EMPLEADOS_DB; integrated security=sspi";
                comando.Connection = conexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "update dbo.Empleados set" +
                    " NombreCompleto='" + empleadoModificado.NombreCompleto + "'" +
                    ",DNI='" + empleadoModificado.Documento + "'" +
                    ",Edad='" + empleadoModificado.Edad + "'" +
                    ",Casado='" + empleadoModificado.Casado + "'" +
                    ",Salario='" + empleadoModificado.Salario + "'" +
                    "where Id='" + empleadoModificado.idEmpleado + "'";
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }

        }

}
}
