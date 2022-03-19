namespace CCPayment.Business.Dtos
{
    public class BinDto
    {
        public int Id { get; set; }

        public string BinCode { get; set; }

        public int BankId { get; set; }

        public int CardTypeId { get; set; }

        public int OrganizationId { get; set; }

        public string IsCommercialCard { get; set; }

        public bool IsSupportInstallment { get; set; }

        public bool IsActive { get; set; }

        public BankDto Bank { get; set; }

        public CardTypeDto CardType { get; set; }

        public OrganizationDto Organization { get; set; }
    }
}
