using LibraryEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryFramework.Infrastructure
{
    public interface IWorkContext
    {
        SysUser Current { get; }
    }
}
