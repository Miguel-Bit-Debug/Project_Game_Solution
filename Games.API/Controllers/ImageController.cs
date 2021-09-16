using Game.Library.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Games.API.Controllers
{
    [Route("v1/api")]
    public class ImageController : Controller
    {
        IHostingEnvironment _appEnvironment;
        //Injeta a instância no construtor para poder usar os recursos
        public ImageController(IHostingEnvironment env)
        {
            _appEnvironment    = env;
        }

        [HttpPost("image")]
        public IActionResult Index([FromForm] GameImageModel image)
        {
            return View();
        }
    }
}
