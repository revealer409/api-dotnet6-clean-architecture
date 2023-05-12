using Microsoft.AspNetCore.Mvc;
using MP.Api.DotNet6.Application.DTOs;
using MP.Api.DotNet6.Application.Services.Interfaces;

namespace MP.ApiDotNet6.Api.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class PersonImageController : ControllerBase {

        private readonly IPersonImageService _personImageService;

        public PersonImageController(IPersonImageService personImageService) {
            _personImageService = personImageService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateImageBase64Async(PersonImageDTO personImageDTO) {
            var result = await _personImageService.CreateImageBase64Async(personImageDTO);

            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);

        }

        [HttpPost]
        [Route("pathimage")]
        public async Task<IActionResult> CreateImageAsync(PersonImageDTO personImageDTO) {
            var result = await _personImageService.CreateImageAsync(personImageDTO);
        
            if(result.IsSuccess) 
                return Ok(result);

            return BadRequest(result);  
        }
    }
}
