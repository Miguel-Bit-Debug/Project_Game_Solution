using Game.App.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Game.App.Controllers
{
    public class GameController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var games = new List<GameModel>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:6000/api/game/"))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    var json = JsonConvert.DeserializeObject<List<GameModel>>(apiResponse);
                }
            }
            return View(games);
        }
    }
}
