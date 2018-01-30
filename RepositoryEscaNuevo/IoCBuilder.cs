using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Data;
using LogicaNegocio.Core;
using LogicaNegocio.Repositorios;

namespace RepositoryEscaNuevo
{
    public class IoCBuilder
    {
        public static IContainer Build()
        {
            var context = new ApplicationDbContext();

            var builder = new ContainerBuilder();
            builder.RegisterInstance(new UnitOfWork(context))
                .As<IUnitOfWork>();

            return builder.Build();
        }
    }
}
