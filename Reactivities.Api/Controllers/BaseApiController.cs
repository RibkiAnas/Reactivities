using MediatR;
using Microsoft.AspNetCore.Mvc;
using Reactivities.Application.Core;

namespace Reactivities.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        private IMediator _metiator;

        protected IMediator Mediator => _metiator ??= HttpContext.RequestServices.GetService<IMediator>();

        protected ActionResult HandleResult<T>(Result<T> result)
        {

            if (result is null) return NotFound();

            if (result.IsSuccess && result.Value != null)
                return Ok(result.Value);

            if (result.IsSuccess && result.Value == null)
                return NotFound();

            return BadRequest(result.Error);
        }
    }
}
