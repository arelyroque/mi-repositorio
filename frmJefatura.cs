using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionVacaciones1
{
    public partial class frmJefatura : Form
    {
        public frmJefatura(string nombreUsuario, string apellidoUsuario)
        {
            InitializeComponent();
            txtNombreJefe.Text = nombreUsuario + " " + apellidoUsuario;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //actualiza el datagridview en tiempo real
        private void RefrescarDataGridViewSolicitudVacaciones()
        {
            string consultaSolicitudes = "SELECT ID_EMPLEADO,ID_SOLICITUD_VACACIONES, TIPO_SOLICITUD,DIAS_SOLICITADOS, ESTADO_SOLICITUD FROM SOLICITUD_VACACIONES ";
            SqlDataAdapter adapter = new SqlDataAdapter(consultaSolicitudes, Conexion.CadenaConexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvSolicitudes.DataSource = dt;
        }

        private void RefrescarDataGridViewSolicitud_Reversion()
        {
            string consultaSolicitudes = "SELECT ID_EMPLEADO,ID_SOLICITUD_REVERSION, TIPO_SOLICITUD,CANT_DIAS_REVERTIDOS, ESTADO_SOLICITUD FROM SOLICITUD_REVERSION ";
            SqlDataAdapter adapter = new SqlDataAdapter(consultaSolicitudes, Conexion.CadenaConexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvSolicitudes.DataSource = dt;
        }

        private void frmJefatura_Load(object sender, EventArgs e)
        {
            //===== cargar el datagridview ========

            //apenas se abre el formulario muestra los datos de la base de datos en el datagridview
            // 1-para ello se crea una cadena de conexion 
            string consulta = "SELECT ID_EMPLEADO,NOMBRE,APELLIDO,FECHA_VACACIONES FROM EMPLEADO";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta,Conexion.CadenaConexion);
            DataTable dt = new DataTable(); //tabla temportal en memoria
            adapter.Fill(dt); //muestra lo que contenga la tabla 
            dgvListaEmpleados.DataSource = dt; // muestra los datos en el datagrid

            //ajustar algunas propiedades del datagridview
            //ReadOnky = true, para que no se pueda modificar sobre los datos 
            //SelectionMode = FullRowSelect


            string consultaSolicitudes = "SELECT ID_EMPLEADO,ID_SOLICITUD_VACACIONES, TIPO_SOLICITUD,DIAS_SOLICITADOS, ESTADO_SOLICITUD FROM SOLICITUD_VACACIONES ";
            SqlDataAdapter adter = new SqlDataAdapter(consultaSolicitudes, Conexion.CadenaConexion);
            DataTable dtt = new DataTable(); //tabla temportal en memoria
            adter.Fill(dtt); //muestra lo que contenga la tabla 
            dgvSolicitudes.DataSource = dtt; // muestra los datos en el datagrid
            //RefrescarDataGridViewSolicitudVacaciones();

            string consultaReversiones = "SELECT ID_EMPLEADO,ID_SOLICITUD_REVERSION, TIPO_SOLICITUD,CANT_DIAS_REVERTIDOS, ESTADO_SOLICITUD FROM SOLICITUD_REVERSION ";
            SqlDataAdapter ad = new SqlDataAdapter(consultaReversiones, Conexion.CadenaConexion);
            DataTable d = new DataTable(); //tabla temportal en memoria
            ad.Fill(d); //muestra lo que contenga la tabla 
            dgvReversion.DataSource = d; // muestra los datos en el datagrid
           // RefrescarDataGridViewSolicitud_Reversion();


            //// Consulta para combinar los datos de ambas tablas
            //// Consulta para combinar los datos de ambas tablas, seleccionando solo los campos necesarios
            //string consultaSolicitudes = @"
            //SELECT 'S/VACACIONES' AS Tipo, ID_EMPLEADO, ID_SOLICITUD_VACACIONES, DIAS_SOLICITADOS, ESTADO_SOLICITUD
            //FROM SOLICITUD_VACACIONES
            //UNION ALL
            //SELECT 'S/REVERSIÓN' AS Tipo, ID_EMPLEADO, ID_SOLICITUD_REVERSION, CANT_DIAS_REVERTIDOS AS DIAS_SOLICITADOS, ESTADO_SOLICITUD
            //FROM SOLICITUD_REVERSION";

            //SqlDataAdapter adter = new SqlDataAdapter(consultaSolicitudes, Conexion.CadenaConexion);
            //DataTable dtt = new DataTable();
            //adter.Fill(dtt);
            //dgvSolicitudes.DataSource = dtt;

        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {

            int idSolicitudVacaciones = Convert.ToInt32(dgvSolicitudes.SelectedRows[0].Cells["ID_SOLICITUD_VACACIONES"].Value);
        

            using (SqlConnection connection = new SqlConnection(Conexion.CadenaConexion))
            {
               
                using (SqlCommand command = new SqlCommand("sp_Aprobar_SolicitudVacaciones", connection))
                {
                    MessageBox.Show(Convert.ToString("Solicitud de vacaciones ID: " + idSolicitudVacaciones));

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID_SolicitudVacaciones", idSolicitudVacaciones);
                    

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Solicitud aprobada correctamente.");
                        RefrescarDataGridViewSolicitudVacaciones();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al aprobar la solicitud: " + ex.Message);
                    }
                }
            }
        }

        private void btnDenegar_Click(object sender, EventArgs e)
        {
            int idSolicitudVacaciones = Convert.ToInt32(dgvSolicitudes.SelectedRows[0].Cells["ID_SOLICITUD_VACACIONES"].Value);
      
            using (SqlConnection connection = new SqlConnection(Conexion.CadenaConexion))
            {
                using (SqlCommand command = new SqlCommand("sp_Denegar_SolicitudVacaciones", connection))
                {
                    MessageBox.Show(Convert.ToString("Solicitud de vacaciones ID: " + idSolicitudVacaciones));

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID_SolicitudVacaciones", idSolicitudVacaciones);
                    

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Solicitud Denegada correctamente.");
                        RefrescarDataGridViewSolicitudVacaciones();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al denegar la solicitud: " + ex.Message);
                    }
                }
            }
        }

    

 

        private void btnAprobarR_Click_1(object sender, EventArgs e)
        {
            int idSolicitudReversion = Convert.ToInt32(dgvReversion.SelectedRows[0].Cells["ID_SOLICITUD_REVERSION"].Value);


            using (SqlConnection connection = new SqlConnection(Conexion.CadenaConexion))
            {

                using (SqlCommand command = new SqlCommand("sp_Aprobar_SolicitudReversion", connection))
                {
                    MessageBox.Show(Convert.ToString("Solicitud de reversión ID: " + idSolicitudReversion));

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID_SolicitudReversion", idSolicitudReversion);
                    RefrescarDataGridViewSolicitud_Reversion();

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Solicitud reversion aprobada correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al aprobar la solicitud: " + ex.Message);
                    }
                }
            }

        }


        private void btnDenegarR_Click(object sender, EventArgs e)
        {
            int idSolicitudReversion = Convert.ToInt32(dgvReversion.SelectedRows[0].Cells["ID_SOLICITUD_REVERSION"].Value);

            using (SqlConnection connection = new SqlConnection(Conexion.CadenaConexion))
            {
                using (SqlCommand command = new SqlCommand("sp_Denegar_SolicitudReversion", connection))
                {
                    MessageBox.Show(Convert.ToString("Solicitud de reversión ID: " + idSolicitudReversion));

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ID_SolicitudReversion", idSolicitudReversion);
                    RefrescarDataGridViewSolicitud_Reversion();

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Solicitud Denegada correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al denegar la solicitud: " + ex.Message);
                    }
                }
            }
        }





    }
}
