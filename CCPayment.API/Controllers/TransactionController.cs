using CCPayment.Business.Services;
using CCPayment.Shared.Controllers;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CCPayment.API.Controllers
{
    [Route("api/[controller]")]
    public class TransactionController : CustomBaseController
    {
        private readonly ITransactionService _transactionService;

        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var result = _transactionService.GetAll();

            return CreateActionResultInstance(result);
        }
    }
}
