using harmonicus.Model.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace harmonicus.Model
{
    [Table("patient")]
    public class Patient : BaseEntity
    {

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("gender")]
        public string Gender { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("cpf")]
        public string Cpf { get; set; }

        public ICollection<Schedule> Schedules { get; set; }
    }
}
