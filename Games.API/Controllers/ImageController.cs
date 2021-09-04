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
        [HttpPost("image")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
