using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace harmonicus.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public Guid Id { get; set; }

    }
}
