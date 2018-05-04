using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiAlumno.Common.Contracts;

namespace WebApiAlumno.DataAccess.Contracts
{
    public interface ICreateDao<T> where T: VuelingObject
    {
        T Create(T entity);
    }
}
