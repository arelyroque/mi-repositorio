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
    public partial class frmSRV : Form
    {
        public frmSRV()
        {
            InitializeComponent();
        }

        private void frmSRV_Load(object sender, EventArgs e)
        {
            string consultaSolicitudes = "SELECT ID_EMPLEADO,ID_SOLICITUD_VACACIONES, FECHA_INICIO, FECHA_FIN, DIAS_SOLICITADOS, ESTADO_SOLICITUD FROM SOLICITUD_VACACIONES";
            SqlDataAdapter adter = new SqlDataAdapter(consultaSolicitudes, Conexion.CadenaConexion);
            DataTable dtt = new DataTable(); //tabla temportal en memoria
            adter.Fill(dtt); //muestra lo que contenga la tabla 
            dgvSolicitudesVacaciones.DataSource = dtt; // muestra los datos en el datagrid
        }

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            // Obtener los datos de los controles de la interfaz (ej: TextBox, ComboBox, etc.)
            string idEmpleado = txtIDEmpleado.Text;
            int cantDias = int.Parse(nudCanRevertir.Text);
            string comentario = txtMotivo.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(Conexion.CadenaConexion))
                {
                    SqlCommand command = new SqlCommand("sp_solicitud_reversion", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Agregar los parámetros al comando
                    command.Parameters.AddWithValue("@id_empleado", idEmpleado);
                    command.Parameters.AddWithValue("@cant_dias_revertidos", cantDias);
                    command.Parameters.AddWithValue("@comentario", comentario);

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Solicitud de reversión enviada correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar la solicitud: " + ex.Message);
            }
        }
    }

}






