using Autofac;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using WebApiAlumno.Business.Contracts;
using WebApiAlumno.Business.Logic;
using WebApiAlumno.DataAccess.Contracts;
using WebApiAlumno.DataAccess.Dao;

namespace WebApiAlumno.Business.Facade.Autofac
{
    public class AutofacWebapiConfig
    {
        public static IContainer Container;

        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config, RegisterServices(new ContainerBuilder()));
        }


        public static void Initialize(HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            //Register your Web API controllers.  
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<AlumnoBl>()
                     .As<ICrudBl>()
                     .InstancePerRequest();

            builder.RegisterGeneric(typeof(GenericDao<>))
                    .As(typeof(ICrudDao<>))
                     .InstancePerRequest();


            //builder.RegisterGeneric(typeof(RedisDao<>))
            //         .As(typeof(IDaoAsync<>))
            //         .InstancePerRequest();

            //builder.RegisterType<RedisDao<User>>()
            //.As<IDaoAsync<User>>()
            //.InstancePerRequest();

            //builder.RegisterType<UserBlAsync>()
            //  .As<IUserBlAsync>()
            //  .InstancePerRequest();


            Container = builder.Build();

            return Container;
        }
    }
}