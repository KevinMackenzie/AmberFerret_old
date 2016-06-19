using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pencil.Gaming.dotnetCoreWorkaround
{
    public static class dotnetCoreUtils
    {
        public static unsafe string sbyteToString(sbyte* str)
        {
            //assume this is a null-terminated string
            int size = 0;
            {
                sbyte next = str[0];
                int i = 0;
                while (next != 0)
                {
                    size++;
                    next = str[++i];
                }
            }
            //now that we have a size, create the string
            string ret = "";
            for(int i = 0; i < size; ++i)
            {
                ret += str[i];
            }

            return ret;
        }
    }
}
