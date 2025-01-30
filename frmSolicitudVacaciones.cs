using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SistemaGestionVacaciones1
{
    public partial class frmSolicitudVacaciones : Form
    {
        public frmSolicitudVacaciones()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //abrir conexion 
            Conexion.OpenConnection();

            using (SqlConnection connection = new SqlConnection(Conexion.CadenaConexion))
            {
                using (SqlCommand command = new SqlCommand("sp_solicitud_vacaciones", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@id_empleado", txtIdEmpleado.Text);
                    command.Parameters.AddWithValue("@fechaInicio", dtpFinicio.Value);
                    command.Parameters.AddWithValue("@fechaFin", dtpFfinal.Value);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                      
                        string query = "SELECT TOP 1 dias_solicitados, estado_solicitud FROM SOLICITUD_VACACIONES ORDER BY ID_SOLICITUD_VACACIONES DESC";
                        SqlCommand selectCommand = new SqlCommand(query, connection);

                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtCantDias.Text = reader.GetInt32(0).ToString(); 
                                txtEstado.Text = reader.GetString(1);
                            }
                            else
                            {
                                MessageBox.Show("No se pudieron recuperar los datos de la solicitud recién creada.");
                            }
                        }

                        MessageBox.Show("Solicitud enviada con éxito.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al enviar la solicitud: " + ex.Message);
                    }
                }
            }

           
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSolicitudVacaciones_Load(object sender, EventArgs e)
        {

        }
    }
}