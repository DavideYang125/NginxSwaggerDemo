using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NginxDemo.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    //[ApiExplorerSettings(GroupName = "servicesa")]
    [ApiController]
    public class TimeController : ControllerBase
    {
        public TimeController()
        {
        }

        /// <summary>
        /// 获取utc时间
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> ZeroTimeAsync()
        {
            var time = DateTime.UtcNow;
            return Ok(time);
        }
    }
}
