using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.DataAccess
{
    public class DataAccessException : ApplicationException
    {
        public DataAccessException(string msg1, Exception msg2)
            : base(msg1, msg2)
        {

        }
        public DataAccessException(string msg)
            : base(msg)
        {

        }
    }
}