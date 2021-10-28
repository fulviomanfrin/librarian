using Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    class User : BaseEntity
    {
        
        public string UserName { get; private set; }

        public string EMail { get; private set; }

        public int Password { get; private set; }
    }
}
