using Game.API.Repositories;
using Game.Library.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Games.API.Controllers
{
    [Route("api/game")]
    public class ListImagesController : Controller
    {
        private readonly IGenericRepository<ImageModel> _context;

        public ListImagesController(IGenericRepository<ImageModel> context)
        {
            _context = context;
        }

        [HttpGet("images")]
        public IActionResult Index()
        {
            var listImg = _context.List().Select(x => x.Data).ToList();
            return Ok(listImg);
        }
    }
}
