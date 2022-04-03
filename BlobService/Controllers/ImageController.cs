using BlobService.Logics;
using BlobService.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlobService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly IFileManagerLogic _fileManagerLogic;
        public ImageController(IFileManagerLogic fileManagerLogic)
        {
            _fileManagerLogic = fileManagerLogic;
        }
        [HttpPost]
        [Route("upload")]
        public async Task<IActionResult> Upload([FromForm] ImageModel imageModel)
        {
            if (imageModel.ImageFile != null)
            {
                await _fileManagerLogic.Upload(imageModel);
            }
            return Ok();

        }
        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> Read(string filename)
        {
            var imgData = await _fileManagerLogic.Read(filename);
            return File(imgData, "image/*");
        }
    }
}
