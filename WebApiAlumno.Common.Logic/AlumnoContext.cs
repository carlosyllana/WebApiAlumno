using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiAlumno.Common.Logic
{
    public class AlumnoContext : DbContext
    {
        public AlumnoContext() : base("AlumnoContext")
        {

            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public DbSet<Alumno> Alumnos { get; set; }

    }
}
