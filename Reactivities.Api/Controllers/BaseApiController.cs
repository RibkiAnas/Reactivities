using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Reactivities.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        private IMediator _metiator;

        protected IMediator Mediator => _metiator ??= HttpContext.RequestServices.GetService<IMediator>();
    }
}
