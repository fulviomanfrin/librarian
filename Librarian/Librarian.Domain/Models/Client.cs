using Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    class Client : BaseEntity
    {
        public string Name { get; private set; }

        public string EMail { get; private set; }

        public int Phone { get; private set; }

        public string Address { get; private set; }


    }
}
// decide logic for flaging an active reservation and rent for a user