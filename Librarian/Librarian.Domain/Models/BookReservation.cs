using Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    class BookReservation : BaseEntity
    {
        public Guid ReservationNumber { get; private set; }

        public DateTime ReservationDate { get; private set; }
    }
}
