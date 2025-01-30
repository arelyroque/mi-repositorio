using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionVacaciones1
{
    public class Vacaciones 
    {
        //atributos de la clase
       public string cedula {  get; set; }
        public int saldoVacaciones { get; set; }
        public string nombre {  get; set; }
        public DateTime fechaIngreso { get; set; }
        public int saldoInicial { get; set; }
        public DateTime FechaAcreditacion { get; set; }


        //constructor vacio
        public Vacaciones()
        {
            
        }

        //constructor con parametros
        public Vacaciones(string cedula,int saldoV, string nombre, DateTime fechaIngreso,int saldoInicial, DateTime fechaAcreditacion)
        {
            this.cedula = cedula;
            this.saldoVacaciones = saldoV;
            this.nombre = nombre;
            this.fechaIngreso = fechaIngreso;
            this.saldoInicial = saldoInicial;
            this.FechaAcreditacion = fechaAcreditacion;
        }

        public override string ToString()
        {
            return $"{cedula},{saldoVacaciones},{nombre},{fechaIngreso:dd-MM-yyyy},{saldoInicial},{FechaAcreditacion:dd-MM-yyyy}";
        }

    }
}
