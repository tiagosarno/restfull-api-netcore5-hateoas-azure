using harmonicus.Business;
using harmonicus.Data.VO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace harmonicus.Controllers
{
    [ApiVersion("1")]
    [Route("api/[controller]/v{version:apiVersion}")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private ILoginBusiness _loginBusiness;

        public AuthController(ILoginBusiness loginBusiness)
        {
            _loginBusiness = loginBusiness;
        }

        [HttpPost]
        [Route("signin")]
        public IActionResult Signin([FromBody] UserVO user)
        {
            if (user == null) return BadRequest("Invalid Client Request");
            var token = _loginBusiness.ValidateCredentials(user);
            if (token == null) return Unauthorized();
            return Ok(token);
        }

        [HttpPost]
        [Route("refresh")]
        public IActionResult Refresh([FromBody] TokenVO tokenVo)
        {
            if (tokenVo == null) return BadRequest("Invalid Client Request");
            var token = _loginBusiness.ValidateCredentials(tokenVo);
            if (token == null) return BadRequest("Invalid Client Request");
            return Ok(token);
        }

        [HttpGet]
        [Route("revoke")]
        [Authorize("Bearer")]
        public IActionResult Revoke()
        {
            var username = User.Identity.Name;
            var result = _loginBusiness.RevokeToken(username);
            if (!result) return BadRequest("Invalid Client Request");
            return NoContent();
        }
    }
}