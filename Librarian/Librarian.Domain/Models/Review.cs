using Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    class Review : BaseEntity
    {
        public int ClientId { get; private set; }

        public string Comment { get; private set; }

        public Enum NumberOfStars { get; private set; }
    }
}
