using Api.Application.Features.Auth.Command.Login;
using Api.Application.Features.Auth.Command.RefreshToken;
using Api.Application.Features.Auth.Command.Register;
using Api.Application.Features.Auth.Command.Revoke;
using Api.Application.Features.Auth.Command.RevokeAll;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ApiProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator mediator;

        public AuthController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterCommandRequest request)
        {
            await mediator.Send(request);
            return StatusCode(StatusCodes.Status201Created);
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginCommandRequest request)
        {
            var response= await mediator.Send(request);
            return StatusCode(StatusCodes.Status200OK,response);
        }
        [HttpPost("Refresh Token")]
        public async Task<IActionResult> RefreshToken(RefreshTokenCommandRequest request)
        {
            var response = await mediator.Send(request);
            return StatusCode(StatusCodes.Status200OK, response);
        }

        [HttpPost("Revoke")]
        public async Task<IActionResult> Revoke(RevokeCommandRequest request)
        {
            var response = await mediator.Send(request);
            return StatusCode(StatusCodes.Status200OK);
        }

        [HttpPost("Revoke All")]
        public async Task<IActionResult> RevokeAll()
        {
            var response = await mediator.Send(new RevokeAllCommandRequest());
            return StatusCode(StatusCodes.Status200OK);
        }
    }
}
