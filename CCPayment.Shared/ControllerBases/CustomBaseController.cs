using CCPayment.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CCPayment.Shared.Controllers
{
    public class CustomBaseController : ControllerBase
    {
        public static IActionResult CreateActionResultInstance<T>(Response<T> response)
        {
            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };
        }
    }
}
