using api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatsController : ControllerBase
    {
        private readonly IChatBotService _testService;

        public ChatsController(IChatBotService testService)
        {
            _testService = testService;
        }

        [HttpGet("{text}")]
        public IActionResult Test(string text)
        {
            var res = _testService.Test(text);
            return Ok(res);
        }
    }
}
