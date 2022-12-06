using MicroServices.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace MicroServices.Shared.ControllerBases
{
    public class CustomBaseController : ControllerBase
    {

        public IActionResult CreateActionResultInstance<T>(Response<T> response)
        {
            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };
        }
    }
}
