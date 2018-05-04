using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiAlumno.Common.Contracts;
using WebApiAlumno.Common.Logic;
using WebApiAlumno.DataAccess.Contracts;

namespace WebApiAlumno.DataAccess.Dao
{
    public class GenericDao<T> : ICrudDao<T> where T : Alumno
    {
        public T Create(T entity)
        {
            try
            {

                using (var context = new AlumnoContext())
                {
                    context.Alumnos.Add(entity);
                    context.SaveChanges();

                    return ReadById(entity.Id);

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int Delete(T entity)
        {
            try
            {
                return DeleteById(entity.Id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int DeleteById(int id)
        {
            try
            {
                using (var context = new AlumnoContext())
                {
                    var student = context.Alumnos
                    .Where(alumno => alumno.Id == id)
                    .FirstOrDefault();

                    context.Alumnos.Remove(student);

                    context.SaveChanges();
                    return 1;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<T> ReadAll()
        {
            try
            {
                using (var context = new AlumnoContext())
                {
                    var alumno = context.Alumnos
                     .ToList<Alumno>();

                    return (List<T>)Convert.ChangeType(alumno, typeof(List<T>));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public T ReadById(int id)
        {
            try
            {
                using (var context = new AlumnoContext())
                {
                    var alumno = context.Alumnos
                     .Where(item => item.Id == id)
                     .FirstOrDefault();

                    return (T)Convert.ChangeType(alumno, typeof(T));
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public T Update(T entity)
        {
            try { 
                using (var context = new AlumnoContext())
                {
                    var studentUpdate = context.Alumnos
                            .Where(alumno => alumno.Id == entity.Id)
                                .FirstOrDefault();


                    studentUpdate.Nombre = entity.Nombre;
                    studentUpdate.Apellido = entity.Apellido;
                    context.SaveChanges();
                    
                    return ReadById(studentUpdate.Id);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
