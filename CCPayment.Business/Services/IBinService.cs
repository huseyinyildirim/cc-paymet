using CCPayment.Business.Dtos;
using CCPayment.Shared.Dtos;

namespace CCPayment.Business.Services
{
    public interface IBinService
    {
        Response<BinDto> GetBinByBinCode(string binCode);
    }
}
