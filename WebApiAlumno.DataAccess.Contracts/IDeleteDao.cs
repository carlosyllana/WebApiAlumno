using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiAlumno.Common.Contracts;

namespace WebApiAlumno.DataAccess.Contracts
{
    public interface IDeleteDao<T> where T: VuelingObject
    {
        int Delete (T entity);
        int DeleteById (int id);

    }
}
