using CCPayment.Business.Dtos;
using CCPayment.Business.Services;
using CCPayment.POS.Providers;
using CCPayment.Shared.Controllers;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CCPayment.API.Controllers
{
    [Route("api/[controller]")]
    public class PaymentController : CustomBaseController
    {
        private readonly ITransactionService _transactionService;
        private readonly IBinService _binService;
    
        public PaymentController(ITransactionService transactionService, IBinService binService)
        {
            _transactionService = transactionService;
            _binService = binService;
        }
        
        [HttpPost]
        public IActionResult Index([FromForm] PaymentDto paymentDto)
        {
            var binResult = _binService.GetBinByBinCode(paymentDto.CardNo.Substring(0, 6));

            PaymentService payment;

            switch (binResult.Data.BankId)
            {
                case 46:
                    payment = new PaymentService(new AkbankProvider());
                    //payment._paymentProvider = new AkbankProvider();
                    break;
                case 62:
                    payment = new PaymentService(new GarantiProvider());
                    //payment._paymentProvider = new GarantiProvider();
                    break;
                default:
                    payment = new PaymentService(new OtherProvider());
                    //payment._paymentProvider = new OtherProvider();
                    break;
            }

            var result = payment.ThreeD(paymentDto);

            if (result.IsSuccessful)
            {
                _transactionService.Create(new TransactionCreateDto
                {
                    BankId = paymentDto.BankId,
                    HolderName = paymentDto.HolderName,
                    CardNo = paymentDto.CardNo,
                    ExpiryMonth = paymentDto.ExpiryMonth,
                    ExpiryYear = paymentDto.ExpiryYear,
                    CVV = paymentDto.CVV,
                    Amount = paymentDto.Amount
                });

                return CreateActionResultInstance(result);

            } else
            {
                return CreateActionResultInstance(result);
            }
            
        }
    }
}
