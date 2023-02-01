using Microsoft.AspNetCore.Mvc;

namespace Dream.Gateway.Api1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        [HttpGet]
        public string Get()
        {
            var host = HttpContext.Request.Host;
            return $"这里是api1_从什么端口请求{host}_时间:{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}";
        }



    }
}
