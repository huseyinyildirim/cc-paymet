using CCPayment.POS.Requests;
using CCPayment.Shared;
using CCPayment.Shared.Dtos;

namespace CCPayment.POS.Providers
{
    public class GarantiProvider : IPaymentProvider
    {
        public GarantiProvider() {}

        public Response<NoContent> Cancel(CancelRequest cancelRequest)
        {
            return Response<NoContent>.Success(HttpStatusCode.NO_CONTENT);
        }

        public Response<NoContent> Detail(DetailRequest detailRequest)
        {
            return Response<NoContent>.Success(HttpStatusCode.NO_CONTENT);
        }

        public Response<NoContent> Refund(RefundRequest refundRequest)
        {
            return Response<NoContent>.Success(HttpStatusCode.NO_CONTENT);
        }

        public Response<NoContent> ThreeD(ThreeDRequest threeDRequest)
        {
            return Response<NoContent>.Success(HttpStatusCode.NO_CONTENT);
        }

        public Response<NoContent> Verify(VerifyRequest verifyRequest)
        {
            return Response<NoContent>.Success(HttpStatusCode.NO_CONTENT);
        }
    }
}