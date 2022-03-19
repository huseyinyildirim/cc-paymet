using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CCPayment.Data.Entities
{
    public class CardType : IEntity
    {
        public int Id { get; set; }

        public string CardTypeName { get; set; }
        [NotMapped]
        public List<Bin> Bins { get; set; }
    }
}
