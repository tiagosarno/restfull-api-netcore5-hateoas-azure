using System.ComponentModel.DataAnnotations.Schema;

namespace harmonicus.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }

    }
}
