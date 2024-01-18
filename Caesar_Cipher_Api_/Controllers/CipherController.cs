using Caesar_Cipher_Api.Contracts;
using Caesar_Cipher_Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Caesar_Cipher_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CipherController : ControllerBase
    {
        private readonly ICipherService _cipherService;

        public CipherController(ICipherService cipherService)
        {
            _cipherService = cipherService;
        }

        [HttpPost, Route("/encrypt")]
        public IActionResult Encrypt(CipherRequest request)
        {
            if (request.Offset < 0) return BadRequest(new BaseResponse(false, 400, null, "offset needs to be a positive number"));

            string encrypted = _cipherService.Encrypt(request.Message, request.Offset);

            return Ok(new CipherResponse(true, 200, request.Offset, encrypted));
        }

        [HttpPost, Route("/decrypt")]
        public IActionResult Decrypt(CipherRequest request)
        {
            if (request.Offset < 0) return BadRequest(new BaseResponse(false, 400, null, "offset needs to be a positive number"));

            string decrypted = _cipherService.Decrypt(request.Message, request.Offset);

            return Ok(new CipherResponse(true, 200, request.Offset, decrypted));
        }

    }
}
