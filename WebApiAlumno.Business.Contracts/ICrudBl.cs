using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiAlumno.Common.Contracts;

namespace WebApiAlumno.Business.Contracts
{
    public interface ICrudBl: ICreateBl, IReadBl, IUpdateBl, IDeleteBl
    {
    }
}
