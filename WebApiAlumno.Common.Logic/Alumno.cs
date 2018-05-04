using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WebApiAlumno.Common.Contracts;

namespace WebApiAlumno.Common.Logic
{
    public class Alumno : VuelingObject
    {

        [Key]
        [Column(Order =0)] 
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        /*public String Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public DateTime FechaRegistro { get; set; }*/


        
    }
        
}
