using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebApiAlumno.Business.Contracts;
using WebApiAlumno.Common.Logic;

namespace WebApiAlumno.Business.Facade.Controllers
{
    public class AlumnoController : ApiController
    {
        private readonly ICrudBl iAlumnoBl;

        public AlumnoController(ICrudBl alumnoBl)
        {
            this.iAlumnoBl = alumnoBl;
        }

        [HttpPost()]
        public  IHttpActionResult CreateAlumno(Alumno alumno)
        {
            try
            {
                    return Ok(this.iAlumnoBl.Create(alumno));

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        [HttpGet()]
        public IHttpActionResult ReadTodo()
        {
            try
            {
                return Ok(this.iAlumnoBl.ReadAll());
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet()]
        public IHttpActionResult ReadById(int id)
        {
            try
            {
                return Ok(this.iAlumnoBl.ReadById(id));
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut()]
        public IHttpActionResult Update(Alumno alumno)
        {
            try
            {
                return Ok(this.iAlumnoBl.Update(alumno));
            }
            catch (Exception)
            {

                throw;
            }
        }

      [HttpDelete()]
        public IHttpActionResult Delete(Alumno alumno)
        {
            try
            {
                
                return Ok(this.iAlumnoBl.Delete(alumno));
            }
            catch (Exception)
            {

                throw;
            }
        }








    }
}
