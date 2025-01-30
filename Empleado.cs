using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionVacaciones1
{
    //clase empleado
    public class Empleado
    {
        private string cedula;
        private string nombre;
        private DateTime fechaIngreso1;
        private object value;

        //atrubutos de la clase
        public string cedulaEmpleado { get; set; }
        public string nombreEmpleado { get; set; }
        public string primerApellidoEmpleado { get; set; } 
        public string segundoApellidoEmpleado { get; set; }
        public string rolEmpleado { get; set; } 
        public string jefeEmpleado { get; set; }
        public string fechaIngreso { get; set; } 
        public int saldoInicialVacaciones { get; set; }         
        public string usuario { get; set; } 
        public string password { get; set; }


        //constructor sin parametros
        public Empleado() 
        {

        }

        //constructor con parametros
        public Empleado(
            string cedulaEmpleado, 
            string nombreEmpleado, 
            string primerApellidoEmpleado,
            string segundoApellidoEmpleado,
            string rolEmpleado, 
            string jefeEmpleado, 
            string fechaIngreso,  
            int saldoInicialVacaciones,
            string usuario, 
            string password)
        {
            this.cedulaEmpleado = cedulaEmpleado;
            this.nombreEmpleado = nombreEmpleado;
            this.primerApellidoEmpleado = primerApellidoEmpleado;
            this.segundoApellidoEmpleado=segundoApellidoEmpleado;
            this.rolEmpleado = rolEmpleado;
            this.jefeEmpleado = jefeEmpleado;
            this.fechaIngreso = fechaIngreso;
            this.saldoInicialVacaciones = saldoInicialVacaciones;
            this.usuario = usuario;
            this.password = password;
            
        }

        public Empleado(string cedula, string nombre, DateTime fechaIngreso1, object value)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.fechaIngreso1 = fechaIngreso1;
            this.value = value;
        }

        public override string ToString()
        {
            return $"{cedulaEmpleado},{nombreEmpleado},{primerApellidoEmpleado},{segundoApellidoEmpleado},{rolEmpleado},{jefeEmpleado},{fechaIngreso:yyyy-MM-dd},{saldoInicialVacaciones},{usuario},{password}";
        }


        //método publico para mostrar la información del empleado
        public string Mostrar_Informacion_Empleado()
        {
            return $"Empleado creado:\n" +
                         $"ID: {cedulaEmpleado}\n" +
                         $"Nombre: {nombreEmpleado}\n" +
                         $"Primer Apellido: {primerApellidoEmpleado}\n" +
                         $"Segundo Apellido: {segundoApellidoEmpleado}\n" +
                         $"Rol de empleado: {rolEmpleado}\n" +
                         $"Jefe asignado: {jefeEmpleado}\n" +
                         $"Fecha de Ingreso: {fechaIngreso}\n" +
                         $"Saldo Inicial Vacaciones: {saldoInicialVacaciones}\n";

        }

        
        
    }
}
