using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilShoppen
{
    internal class User
    {
            public string firstname = "unknown";

            public string lastname = "unknown";

            public string email = "unknown";

            public object GetName()
            {

                return new { this.firstname, this.lastname, this.email };
            }
 
    }
}
