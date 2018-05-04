using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiAlumno.Common.Contracts;
using WebApiAlumno.Common.Logic;

namespace WebApiAlumno.Business.Contracts
{
    public interface ICreateBl
    {
        Alumno Create(Alumno alumno);

    }
}
