using Game.API.Data;
using Game.API.Repositories;
using Game.Library.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Games.API.Controllers
{
    [Route("api/game")]
    public class UploadController : Controller
    {
        private readonly IGenericRepository<ImageModel> _context;

        public UploadController(IGenericRepository<ImageModel> context)
        {
            _context = context;
        }

        [HttpPost("upload")]
        public IActionResult UploadImage([FromForm] IFormFile file)
        {
            if (file != null)
            {
                MemoryStream ms = new MemoryStream();
                file.OpenReadStream().CopyTo(ms);

                var image = new ImageModel()
                {
                    Name = file.FileName,
                    Data = ms.ToArray(),
                    ContentType = file.ContentType
                };
                _context.AddAsync(image);
                return Ok("Success");
            }

            return BadRequest();
        }
    }
}
