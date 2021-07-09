using Autofac;
using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demo_AutoFac
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            
            builder.RegisterType<Application>().As<IApplication>();

            //Manera sencilla de registrar servicios.
            builder.RegisterType<BussinessLogic>().As<IBussinessLogic>();

            

            //De esta forma se registran globalmente a modo de assembly
            //Tomando como referencia que las interfaces se nombran I + Nombre de Clase
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(DemoLibrary)))
                .Where(t=>t.Namespace.Contains("Services"))
                .As(t=>t.GetInterfaces().FirstOrDefault(i=>i.Name == "I" + t.Name));

            return builder.Build();
        }
    }
}
