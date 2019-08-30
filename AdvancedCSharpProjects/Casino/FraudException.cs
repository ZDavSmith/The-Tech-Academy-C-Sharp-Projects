using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class FraudException: Exception
    {
        public FraudException()
            : base() { }//Inherriting from the bsae exception(Exception)
        public FraudException(string message)
            : base(message) { }

    }
}
