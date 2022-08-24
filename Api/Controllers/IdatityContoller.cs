using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Api.Controllers
{
    [Route("identity")]
    [Authorize]
    public class IdatityContoller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult
                (
                    from c in User.Claims
                    select new { c.Type, c.Value }
                );
        }
    }
}
