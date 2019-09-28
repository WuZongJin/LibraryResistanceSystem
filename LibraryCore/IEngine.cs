using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCore
{
    public interface IEngine
    {
        T Resolve<T>() where T : class;
    }
}
