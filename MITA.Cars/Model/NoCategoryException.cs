using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class NoCategoryException : ApplicationException
    {
        public NoCategoryException() { }

        public NoCategoryException(string message) : base(message) { }
    }
}
