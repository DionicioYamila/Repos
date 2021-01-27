using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NoSeGuardoExeception: Exception
    {
        public NoSeGuardoExeception(Exception innerException)
        {
        }
    }
}
