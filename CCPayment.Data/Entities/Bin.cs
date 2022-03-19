using System.ComponentModel.DataAnnotations.Schema;

namespace CCPayment.Data.Entities
{
    public class Bin : IEntity
    {
        public int Id { get; set; }

        public string BinCode { get; set; }

        public int BankId { get; set; }

        public int CardTypeId { get; set; }

        public int OrganizationId { get; set; }

        public bool IsCommercialCard { get; set; }

        public bool IsSupportInstallment { get; set; }

        public bool IsActive { get; set; }

        [NotMapped]
        public Bank Bank { get; set; }
        [NotMapped]
        public CardType CardType { get; set; }
        [NotMapped]
        public Organization Organization { get; set; }
    }
}