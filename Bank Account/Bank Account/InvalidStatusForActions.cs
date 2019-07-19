using System;
using System.Collections.Generic;
using System.Text;

namespace Bank_Account
{
    public class InvalidStatusForActions : SystemException
    {
        public InvalidStatusForActions(string message = "Any operation on a closed account is not permitted.") : base(message)
        {

        }
    }
}
