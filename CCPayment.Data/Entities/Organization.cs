using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CCPayment.Data.Entities
{
    public class Organization : IEntity
    {
        public int Id { get; set; }

        public string OrganizationName { get; set; }
        [NotMapped]
        public List<Bin> Bins { get; set; }
    }
}
