using LibraryCore;
using LibraryFramework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryFramework.Controllers
{
    public class PublicAdminController
    {

        private IWorkContext _workContext;

        public PublicAdminController()
        {
            _workContext = EngineContext.Current.Resolve<IWorkContext>();
        }

        public IWorkContext WorkContext
        {
            get { return _workContext; }
        }
    }
}
