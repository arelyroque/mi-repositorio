using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionVacaciones1
{
    public partial class frmEmpleado : Form
    {
        public frmEmpleado(string nombreUsuario, string apellidoUsuario, DateTime fechaIngreso, DateTime fechaVacaciones, string jefe, int cantVacaciones)
        {
            InitializeComponent();
            lblNombreEmpleado.Text = nombreUsuario + " " + apellidoUsuario;
            mskFechaIngreso.Text = fechaIngreso.ToString();
            mskFechaVacaciones.Text = fechaVacaciones.ToString();
            txtJefe.Text = jefe.ToString();
            txtCantVacAcum.Text = cantVacaciones.ToString();
        }

        private void btnSDV_Click(object sender, EventArgs e)
        {
            frmSolicitudVacaciones SV = new frmSolicitudVacaciones(); SV.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
          Application.Exit();
        }

        private void btnSRV_Click(object sender, EventArgs e)
        {
            frmSRV frmSRV = new frmSRV();
            frmSRV.ShowDialog();
            
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            
        }
    }
}
