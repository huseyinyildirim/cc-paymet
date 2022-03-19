using AutoMapper;
using CCPayment.Business.Dtos;
using CCPayment.Data.Repository;
using CCPayment.Shared;
using CCPayment.Shared.Dtos;

namespace CCPayment.Business.Services
{
    public class BinService : IBinService
    {
        private readonly IBinRepository _binRepository;
        private readonly IMapper _mapper;

        public BinService(IMapper mapper, IBinRepository binRepository)
        {
            _mapper = mapper;
            _binRepository = binRepository;
        }

        public Response<BinDto> GetBinByBinCode(string binCode)
        {
            var bin = _binRepository.GetBinByBinCode(binCode);

            if (bin == null)
            {
                return Response<BinDto>.Fail(Messages.NOT_FOUND, HttpStatusCode.NOT_FOUND);
            }

            return Response<BinDto>.Success(_mapper.Map<BinDto>(bin), HttpStatusCode.OK);
        }
    }
}