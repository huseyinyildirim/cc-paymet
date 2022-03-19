using CCPayment.POS.Requests;
using CCPayment.Shared.Dtos;

namespace CCPayment.POS
{
    public interface IPaymentProvider
    {
        Response<NoContent> ThreeD(ThreeDRequest threeDRequest);

        Response<NoContent> Verify(VerifyRequest verifyRequest);

        Response<NoContent> Cancel(CancelRequest cancelRequest);

        Response<NoContent> Refund(RefundRequest refundRequest);

        Response<NoContent> Detail(DetailRequest detailRequest);
    }
}
