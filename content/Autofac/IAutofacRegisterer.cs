using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Web.Autofac
{
    internal interface IAutofacRegisterer
    {
        void RegisterModules(IEnumerable<AssemblyName> assemblyNames);
        void RegisterConfiguration(IConfiguration configuration);
        void Populate(IServiceCollection services);
        IServiceProvider GetServiceProvider();
    }
}
