using AutoMapper;
using CCPayment.Business.Dtos;
using CCPayment.POS;
using CCPayment.POS.Requests;
using CCPayment.Shared;
using CCPayment.Shared.Dtos;

namespace CCPayment.Business.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IMapper _mapper;
        IPaymentProvider _paymentProvider;

        public PaymentService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public PaymentService(IPaymentProvider paymentProvider)
        {
            _paymentProvider = paymentProvider;
        }

        /*private readonly IMapper _mapper;
        public IPaymentProvider _paymentProvider { get; set; }

        public PaymentService(IPaymentProvider paymentProvider, IMapper mapper)
        {
            _mapper = mapper;
            _paymentProvider = paymentProvider;
        }

        public PaymentService()
        {
        }*/

        public Response<NoContent> ThreeD(PaymentDto paymentDto)
        {
            //var request = _mapper.Map<ThreeDRequest>(paymentDto);

            ThreeDRequest threeDRequest = new()
            {
                HolderName = paymentDto.HolderName,
                CardNo = paymentDto.CardNo,
                ExpiryMonth = paymentDto.ExpiryMonth,
                ExpiryYear = paymentDto.ExpiryYear,
                CVV = paymentDto.CVV,
                Amount = paymentDto.Amount
            };

            var result = _paymentProvider.ThreeD(threeDRequest);

            if (result.IsSuccessful)
            {
                return Response<NoContent>.Success(HttpStatusCode.NO_CONTENT);
            }
            else
            {
                return Response<NoContent>.Fail(result.Errors, HttpStatusCode.NO_CONTENT);
            }
        }

        public Response<NoContent> Verify(PaymentTransactionDto paymentTransactionDto)
        {
            var request = _mapper.Map<VerifyRequest>(paymentTransactionDto);

            var result = _paymentProvider.Verify(request);

            if (result.IsSuccessful)
            {
                return Response<NoContent>.Success(HttpStatusCode.NO_CONTENT);
            }
            else
            {
                return Response<NoContent>.Fail(result.Errors, HttpStatusCode.NO_CONTENT);
            }
        }

        public Response<NoContent> Refund(PaymentTransactionDto paymentTransactionDto)
        {
            var request = _mapper.Map<RefundRequest>(paymentTransactionDto);

            var result = _paymentProvider.Refund(request);

            if (result.IsSuccessful)
            {
                return Response<NoContent>.Success(HttpStatusCode.NO_CONTENT);
            }
            else
            {
                return Response<NoContent>.Fail(result.Errors, HttpStatusCode.NO_CONTENT);
            }
        }

        public Response<NoContent> Cancel(PaymentTransactionDto paymentTransactionDto)
        {
            var request = _mapper.Map<CancelRequest>(paymentTransactionDto);

            var result = _paymentProvider.Cancel(request);

            if (result.IsSuccessful)
            {
                return Response<NoContent>.Success(HttpStatusCode.NO_CONTENT);
            }
            else
            {
                return Response<NoContent>.Fail(result.Errors, HttpStatusCode.NO_CONTENT);
            }
        }

        public Response<NoContent> Detail(PaymentTransactionDto paymentTransactionDto)
        {
            var request = _mapper.Map<DetailRequest>(paymentTransactionDto);

            var result = _paymentProvider.Detail(request);

            if (result.IsSuccessful)
            {
                return Response<NoContent>.Success(HttpStatusCode.NO_CONTENT);
            }
            else
            {
                return Response<NoContent>.Fail(result.Errors, HttpStatusCode.NO_CONTENT);
            }
        }
    }
}
