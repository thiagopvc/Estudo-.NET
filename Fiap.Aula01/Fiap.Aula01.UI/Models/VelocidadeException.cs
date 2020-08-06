using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.Aula01.UI.Models
{

    [Serializable]
    public class VelocidadeException : Exception
    {
        public VelocidadeException() { }
        public VelocidadeException(string message) : base(message) { }
        public VelocidadeException(string message, Exception inner) : base(message, inner) { }
        protected VelocidadeException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
    
}
