using Microsoft.AspNetCore.Mvc;

namespace Caesar_Cipher_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CipherController : ControllerBase
    {
        private readonly ILogger<CipherController> _logger;

        public CipherController(ILogger<CipherController> logger)
        {
            _logger = logger;
        }

    }
}
