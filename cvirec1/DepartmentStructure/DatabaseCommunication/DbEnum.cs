using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCommunication
{
    // Enum netreba dávať do triedy.
    public static class DbEnum
    {
        public enum DBResposeType { OK, NotOK, ConnectionError, SQLError };
    }
}
