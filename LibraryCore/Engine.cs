using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace LibraryCore
{
    public class Engine:IEngine
    {
        private IServiceProvider _provider;
        public Engine(IServiceProvider provider)
        {
            _provider = provider;
        }

        public T Resolve<T>() where T : class
        {
            return _provider.GetService<T>();
        }

    }
}
