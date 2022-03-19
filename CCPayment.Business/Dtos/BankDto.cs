using System.Collections.Generic;

namespace CCPayment.Business.Dtos
{
    public class BankDto
    {
        public int Id { get; set; }

        public string BankName { get; set; }

        public List<BinDto> Bins { get; set; }

        public List<TransactionDto> Transactions { get; set; }
    }
}
