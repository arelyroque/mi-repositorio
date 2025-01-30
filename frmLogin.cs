//1- Importar librerias
using System;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;


namespace SistemaGestionVacaciones1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //2- crear variable de conexion 

        SqlConnection conexion = new SqlConnection(@"Data Source=ARELY;Initial Catalog=VACACIONES;Integrated Security=True");

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Abrir la conexión
            conexion.Open();

            // Consulta SQL con parámetro para evitar inyección SQL
            string consulta = "SELECT * FROM EMPLEADO WHERE USUARIO = @usuario AND PASSWORD = @password";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("@usuario", txtUser.Text);
            comando.Parameters.AddWithValue("@password", txtPass.Text);

          
            SqlDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                // Obtener el rol del usuario
                int rol = (int)lector["ROL"];

                // Validar el rol y abrir el formulario correspondiente
                switch (rol)
                {
                    //case 1:
                    //    // Abrir formulario de empleado
                    //    frmRH1 frmRH = new frmRH1();
                    //    this.Hide();
                    //    frmRH.Show();
                    //    break;
                    case 2:
                        // Abrir formulario de empleado
                        DateTime fechaIngreso = Convert.ToDateTime(lector["FECHA_INGRESO"]);
                        DateTime fechaVacaciones = Convert.ToDateTime(lector["FECHA_VACACIONES"]);
                        int cantVacaciones = Convert.ToInt32(lector["CANT_VAC_ACUM"]);

                        frmEmpleado frmEmpleado = new frmEmpleado(
                            lector["NOMBRE"].ToString(),
                            lector["APELLIDO"].ToString(),
                            fechaIngreso,
                            fechaVacaciones,
                            lector["JEFE"].ToString(),
                            cantVacaciones
                        );

                        this.Hide();
                        frmEmpleado.Show();
                        break;
                    case 3:
                        // Abrir formulario de jefatura
                        string nombreJefeLogeado = lector["JEFE"].ToString(); // Obtener el nombre del jefe logeado

                        frmJefatura frmJefatura = new frmJefatura(
                            lector["NOMBRE"].ToString(),
                            lector["APELLIDO"].ToString());

                       
                        this.Hide();
                        frmJefatura.Show();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Debe solicitar a RH el registro de ingreso al módulo");
            }

            conexion.Close();
        }
    }
}