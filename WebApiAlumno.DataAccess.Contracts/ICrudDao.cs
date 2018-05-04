using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiAlumno.Common.Contracts;

namespace WebApiAlumno.DataAccess.Contracts
{
    public interface ICrudDao<T> : ICreateDao<T>, IReadDao<T>,IUpdateDao<T>, IDeleteDao<T> where T:VuelingObject
    {
    }
}
