using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/file")]
    public class FileController : ControllerBase
    {
        private readonly ICloudStorageService _cloudStorageService;

        public FileController(ICloudStorageService cloudStorageService)
        {
            _cloudStorageService = cloudStorageService;
        }

        [HttpPost]
        [Route("upload-image")]
        public async Task<IActionResult> UploadImage(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("No file uploaded");

            var uploadResult = await _cloudStorageService.UploadFileAsync(file);

            if (uploadResult.Url == null || string.IsNullOrEmpty(uploadResult.Url.ToString()))
                return StatusCode(500, "Failed to upload image");

            return Ok(new { imageUrl = uploadResult.Url.ToString() });
        }
    }
}