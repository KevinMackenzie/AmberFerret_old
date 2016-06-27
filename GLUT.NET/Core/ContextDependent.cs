using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GLUT.NET.Core
{
    public abstract class ContextDependent
    {
        public readonly ContextInfo CtxtInfo = new ContextInfo();

        public ContextDependent(ContextInfo info)
        {
            CtxtInfo = info;
        }
    }
}
