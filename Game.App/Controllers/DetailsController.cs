using Game.App.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Game.App.Controllers
{
    public class DetailsController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index(Guid id)
        {
            GameModel game = new GameModel();
            using(var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"http://localhost:5000/api/game/{id}"))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    game = JsonConvert.DeserializeObject<GameModel>(apiResponse);
                }
            }

            return View(game);
        }
    }
}
