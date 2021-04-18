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
        public async Task<IActionResult> Index(GameModel game)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:6000/api/game"))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                }

                return View(game);
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddGame(GameModel game)
        {
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(game),
                                                Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync("http://localhost:6000/api/game", content))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    game = JsonConvert.DeserializeObject<GameModel>(apiResponse);
                }

                return RedirectToAction("Index", "Home");
            }
        }
    }
}
