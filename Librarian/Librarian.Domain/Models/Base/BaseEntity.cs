﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Librarian.Models.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }

    }
}
