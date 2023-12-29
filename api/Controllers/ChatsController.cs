using api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatsController : ControllerBase
    {
        private readonly IChatBotService _chatBotService;

        public ChatsController(IChatBotService chatbotService)
        {
            _chatBotService = chatbotService;
        }

        [HttpGet("{text}")]
        public async Task<IActionResult> Test(string text)
        {
            var res = await _chatBotService.Test(text);
            return Ok(res);
        }
    }
}
