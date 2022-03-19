using CCPayment.Business.Dtos;
using CCPayment.Shared.Dtos;

namespace CCPayment.Business.Services
{
    public interface IPaymentService
    {
        Response<NoContent> ThreeD(PaymentDto paymentDto);

        Response<NoContent> Verify(PaymentTransactionDto paymentTransactionDto);

        Response<NoContent> Cancel(PaymentTransactionDto paymentTransactionDto);

        Response<NoContent> Refund(PaymentTransactionDto paymentTransactionDto);

        Response<NoContent> Detail(PaymentTransactionDto paymentTransactionDto);
    }
}
