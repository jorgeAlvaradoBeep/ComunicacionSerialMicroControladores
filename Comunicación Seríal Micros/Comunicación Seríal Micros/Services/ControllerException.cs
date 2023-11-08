using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunicación_Seríal_Micros.Services
{
    class ControllerException : Exception
    {
        public ControllerException()
        {
        }
        public ControllerException(string message)
            : base(message)
        {
        }
        public ControllerException(string message, Exception inner)
            : base(message, inner)
        {
        }
        protected ControllerException(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context)
        {
        }
    }
}
