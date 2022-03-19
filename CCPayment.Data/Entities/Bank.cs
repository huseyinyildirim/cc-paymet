using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CCPayment.Data.Entities
{
    public class Bank : IEntity
    {
        public int Id { get; set; }

        public string BankName { get; set; }
        [NotMapped]
        public List<Bin> Bins { get; set; }
        [NotMapped]
        public List<Transaction> Transactions { get; set; }
    }
}
