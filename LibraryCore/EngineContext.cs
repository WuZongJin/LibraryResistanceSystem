using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace LibraryCore
{
    public class EngineContext
    {
        private static IEngine _engine;

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static IEngine Initialize(IEngine engine)
        {
            if (_engine == null)
                _engine = engine;
            return _engine;
        }

        public static IEngine Current
        {
            get { return _engine; }
        }
    }
}
