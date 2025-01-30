using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionVacaciones1
{
    public partial class frmRH1 : Form
    {
      
       
        public frmRH1()
        {
            InitializeComponent();
          
        }

        private void btnRE_Click(object sender, EventArgs e)
        {
            //abre formulario
            frmRegistroEmpleado frmRE = new frmRegistroEmpleado();
            frmRE.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //cierra aplicacion
            Application.Exit();
        }

        private void frmRH1_Load(object sender, EventArgs e)
        {
            // Obtener el usuario actual desde la sesión
            Usuario usuario = Sesion.UsuarioActual;

            // Mostrar el Nombre del usuario en linea en el label
            lblHola.Text = usuario.MostrarSaludo();

            // Ruta al archivo
            string rutaArchivo = "Empleado.txt";

            // Leer el archivo y cargar los datos en el DataGridView
            using (StreamReader sr = new StreamReader(rutaArchivo))
            {
                string linea;
                while ((linea = sr.ReadLine()) != null)
                {
                    string[] datos = linea.Split(',');
                    // Crear una nueva fila en el DataGridView
                    int indiceFila = dgvRH.Rows.Add();

                    // Asignar los valores a las celdas de la fila
                    dgvRH.Rows[indiceFila].Cells[0].Value = datos[0]; // ID
                    dgvRH.Rows[indiceFila].Cells[1].Value = datos[1]; // Nombre
                    dgvRH.Rows[indiceFila].Cells[2].Value = datos[2]; // Apellido1
                    dgvRH.Rows[indiceFila].Cells[3].Value = datos[3]; // Apellido2
                                                                      //// dgvRH.Rows[indiceFila].Cells[1].Value = datos[4]; // Fecha de acreditacion
                                                                      ////dgvRH.Rows[indiceFila].Cells[1].Value = datos[5]; // Saldo de vacaciones

                }
            }
        }

        private void btnCV_Click(object sender, EventArgs e)
        {
            //abre formulario calculo vacaciones
            CalculoVacaciones calculoVacaciones = new CalculoVacaciones();
            calculoVacaciones.ShowDialog();
        }
    }
}
