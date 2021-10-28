using Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    class Author : BaseEntity
    {
        public string AuthorName { get; private set; }
    }
}
