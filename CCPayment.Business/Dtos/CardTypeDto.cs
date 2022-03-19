using System.Collections.Generic;

namespace CCPayment.Business.Dtos
{
    public class CardTypeDto
    {
        public int Id { get; set; }

        public string CardTypeName { get; set; }

        public List<BinDto> Bins { get; set; }
    }
}
