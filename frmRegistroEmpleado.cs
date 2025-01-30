using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SistemaGestionVacaciones1
{
    public partial class frmRegistroEmpleado : Form
    {
       
        public frmRegistroEmpleado()
        {
            InitializeComponent();
        }

        private void frmRegistroEmpleado_Load(object sender, EventArgs e)
        {
            //al ejecutar el formulario, hará la consulta si existe el archivo Empleado
            if (!File.Exists(@"Empleado.txt"))
            {
                //sino existe lo creará y cierra el archivo
                StreamWriter archivo = new StreamWriter(@"Empleado.txt");
                archivo.Close();
            }
           
                   
        }

        public void LimpiarFormulario()
        {
            // Limpia los campos de texto
            txtApellido1E.Clear();
            txtApellido2E.Clear();
            txtNombreE.Clear();
            txtUsuarioname.Clear();
            txtPassword.Clear();


            // Limpia los campos numéricos y de fecha
            NudSaldo_Inicial_Vacaciones.Value = 0;
            mskFechaIngreso.Clear();
            mskIDEmpleado.Clear();

            // Restablece los ComboBox
            cmbJefe.SelectedIndex = -1; // O cmbJefe.SelectedItem = null;
            cmbRolEmpleado.SelectedIndex = -1; // O cmbRolEmpleado.SelectedItem = null;

            mskIDEmpleado.Focus();
        }

       
        private void btnSalir_Click(object sender, EventArgs e)
        {
            //cierra formulario
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Obtener la fecha seleccionada
            DateTime fechaSeleccionada = e.Start;

            // Formatear la fecha según el formato deseado
            string fechaFormateada = fechaSeleccionada.ToString("dd/MM/yyyy");

            // Asignar la fecha formateada al MaskedTextBox
            mskFechaIngreso.Text = fechaFormateada;
        }


        //metodo para comprobar existencia de empleado en el archivo
        public bool ExisteEmpleado(string idEmpleado)
        {
            using (StreamReader reader = new StreamReader(@"Empleado.txt"))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    string[] datos = linea.Split(',');
                    string idEnArchivo = datos[0];

                    if (idEnArchivo == idEmpleado)
                    {
                        return true; // El ID ya existe
                    }
                }
            }

            return false; // El ID no existe
        }

        //valida campos
        private bool ValidarDatosCliente()
        {
            
            if (string.IsNullOrWhiteSpace(mskIDEmpleado.Text) ||
                string.IsNullOrWhiteSpace(txtNombreE.Text) ||
                string.IsNullOrWhiteSpace(txtApellido1E.Text) ||
                string.IsNullOrWhiteSpace(txtApellido2E.Text) ||
                string.IsNullOrWhiteSpace(txtUsuarioname.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                cmbJefe.SelectedIndex == -1 ||
                cmbRolEmpleado.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(mskFechaIngreso.Text))
            {
                MessageBox.Show("Debe ingresar todos los datos del empleado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskIDEmpleado.Focus(); 
                return false;
            }

            return true;
        }

        //metoodo para guarda el registro del empleado
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatosCliente())
                return;
            // Validar campos obligatorios

            string nuevoId = mskIDEmpleado.Text;

            // Verificar si el ID ya existe antes de guardar
            if (ExisteEmpleado(nuevoId))
            {
                MessageBox.Show("La cédula del empleado ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Empleado empleado = new Empleado(
                                mskIDEmpleado.Text,
                                txtNombreE.Text.ToUpper(),
                                txtApellido1E.Text.ToUpper(),
                                txtApellido2E.Text.ToUpper(),
                                cmbRolEmpleado.SelectedItem.ToString().ToUpper(), // Obtener el valor seleccionado del ComboBox
                                cmbJefe.SelectedItem.ToString().ToUpper(),
                                mskFechaIngreso.Text,
                                (int)NudSaldo_Inicial_Vacaciones.Value, // Convertir NumericUpDown a entero
                                txtUsuarioname.Text.ToUpper(),
                                txtPassword.Text.ToUpper());

                using (StreamWriter archivo = new StreamWriter(@"Empleado.txt", true))
                {
                    archivo.WriteLine(empleado.ToString());
                }

                MessageBox.Show("Empleado guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();


            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el empleado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }




        }

        private Empleado BuscarEmpleadoPorCedula(string cedula)
        {
            Empleado empleadoEncontrado = null;

            try
            {
                using (StreamReader reader = new StreamReader(@"Empleado.txt"))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                       
                        string[] datosEmpleado = linea.Split(',');

                        if (datosEmpleado[0] == cedula)
                        {
                            // Validar la cantidad de elementos en datosEmpleado para evitar IndexOutOfRangeException
                            // Ajusta el número según la cantidad de campos en tu archivo
                            if (datosEmpleado.Length >= 10)
                            {
                                empleadoEncontrado = new Empleado(
                                datosEmpleado[0],
                                datosEmpleado[1],
                                datosEmpleado[2],
                                datosEmpleado[3],
                                datosEmpleado[4],
                                datosEmpleado[5],
                                datosEmpleado[6],
                                int.Parse(datosEmpleado[7]),
                                datosEmpleado[8],
                                datosEmpleado[9]);
                                break;

                            }
                            else
                            {
                                MessageBox.Show("Formato de datos incorrecto en el archivo.");
                                break;
                            }


                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return empleadoEncontrado;
        }

        private void btbConsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mskIDEmpleado.Text))
            {
                MessageBox.Show("Debe ingresar la cédula del empleado a consultar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskIDEmpleado.Focus();
                return;
            }

            string cedulaBuscar = mskIDEmpleado.Text;
            Empleado empleadoEncontrado = BuscarEmpleadoPorCedula(cedulaBuscar);

            if (empleadoEncontrado != null)
            {
                // Cargar los datos del empleado en los controles
                txtNombreE.Text = empleadoEncontrado.nombreEmpleado;
                txtApellido1E.Text = empleadoEncontrado.primerApellidoEmpleado;
                txtApellido2E.Text = empleadoEncontrado.segundoApellidoEmpleado;
                cmbRolEmpleado.SelectedItem = empleadoEncontrado.rolEmpleado;
                cmbJefe.SelectedItem = empleadoEncontrado.jefeEmpleado; 
                mskFechaIngreso.Text = empleadoEncontrado.fechaIngreso;
                NudSaldo_Inicial_Vacaciones.Value = empleadoEncontrado.saldoInicialVacaciones;
                txtUsuarioname.Text = empleadoEncontrado.usuario;
                txtPassword.Text = empleadoEncontrado.password;
            }
            else
            {
                MessageBox.Show("No se encontró un empleado con esa cédula.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }

            // Si se encontró el empleado, habilitar el botón de eliminar
            btnEliminar.Enabled = empleadoEncontrado != null;
            
        }

       
        //metodo para eliminar empleado
        private void EliminarEmpleado(string cedula)
        {
            List<string> lineas = new List<string>();
            using (StreamReader reader = new StreamReader("Empleado.txt"))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    string[] campos = linea.Split(','); // Ajustar al separador deL archivo
                    string cedulaEmpleado = campos[0];
                    if (cedulaEmpleado != cedula)
                    {
                        lineas.Add(linea);
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter("Empleado.txt"))
            {
                foreach (string linea in lineas)
                {
                    writer.WriteLine(linea);
                }
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string cedulaBuscar = mskIDEmpleado.Text;
            Empleado empleadoEncontrado = BuscarEmpleadoPorCedula(cedulaBuscar);

            if (empleadoEncontrado == null)
            {
                MessageBox.Show("No hay un empleado seleccionado para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Confirmar la eliminación
            DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar el empleado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                // Eliminar el empleado del archivo
                EliminarEmpleado(empleadoEncontrado.cedulaEmpleado);

                // Limpiar el formulario y deshabilitar el botón de eliminar
                LimpiarFormulario();
                btnEliminar.Enabled = false;

                MessageBox.Show("Empleado eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
