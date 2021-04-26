using Game.App.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Game.App.Controllers
{
    public class PostController : Controller
    {
            [HttpGet]
            public IActionResult Index()
            {
                return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromForm]GameModel game)
        {
            using (var client = new HttpClient())
            {
                var serializedProduto = JsonConvert.SerializeObject(game);
                var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                var result = await client.PostAsync("http://localhost:5000/api/game/", content);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
