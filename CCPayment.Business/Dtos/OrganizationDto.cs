using System.Collections.Generic;

namespace CCPayment.Business.Dtos
{
    public class OrganizationDto
    {
        public int Id { get; set; }

        public string OrganizationName { get; set; }

        public List<BinDto> Bins { get; set; }
    }
}
