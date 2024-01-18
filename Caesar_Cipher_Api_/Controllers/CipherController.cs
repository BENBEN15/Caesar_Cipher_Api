using Caesar_Cipher_Api.Contracts;
using Caesar_Cipher_Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Caesar_Cipher_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CipherController : ControllerBase
    {
        private readonly ILogger<CipherController> _logger;
        private readonly ICipherService _cipherService;

        public CipherController(ILogger<CipherController> logger, ICipherService cipherService)
        {
            _logger = logger;
            _cipherService = cipherService;
        }

        [HttpGet, Route("/encrypt")]
        public IActionResult Encrypt(CipherRequest request)
        {
            if (request == null) return BadRequest(new BaseResponse(false, 400, null, "missing request body"));

            if (request.Offset < 0) return BadRequest(new BaseResponse(false, 400, null, "offset needs to be a positive number"));

            if (request.Message == null) return BadRequest(new BaseResponse(false, 400, null, "request is missing the message"));

            string encrypted = _cipherService.Encrypt(request.Message, request.Offset);

            return Ok(new CipherResponse(true, 200, request.Offset, encrypted));
        }

        [HttpGet, Route("/decrypt")]
        public IActionResult Decrypt(CipherRequest request)
        {
            if (request == null) return BadRequest(new BaseResponse(false, 400, null, "missing request body"));

            if (request.Offset < 0) return BadRequest(new BaseResponse(false, 400, null, "offset needs to be a positive number"));

            if (request.Message == null) return BadRequest(new BaseResponse(false, 400, null, "request is missing the message"));

            string decrypted = _cipherService.Decrypt(request.Message, request.Offset);

            return Ok(new CipherResponse(true, 200, request.Offset, decrypted));
        }

    }
}
