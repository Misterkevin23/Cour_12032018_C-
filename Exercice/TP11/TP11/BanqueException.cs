using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP11
{
    #region Constructeur
    [Serializable]
    public class BanqueException : Exception
    {
        public BanqueException() { }
        public BanqueException(string message) : base(message) { }
        public BanqueException(string message, Exception inner) : base(message, inner) { }
        protected BanqueException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
        #endregion
}
