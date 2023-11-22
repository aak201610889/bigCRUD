using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace bigCRUD.Core
{
    public static class GetCoreAssembly
    {
        public static Assembly assembly => Assembly.GetExecutingAssembly();
    }
}
