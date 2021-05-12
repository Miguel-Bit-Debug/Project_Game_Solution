using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Game.App.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace Game.App.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var games = new List<GameModel>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5000/api/game"))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    games = JsonConvert.DeserializeObject<List<GameModel>>(apiResponse);
                }
            }
            return View(games);
        }
    }
}
