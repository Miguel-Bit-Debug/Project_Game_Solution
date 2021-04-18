using Game.App.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
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
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("http://localhost:6000/api/game"))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    games = JsonConvert.DeserializeObject<List<GameModel>>(apiResponse);
                }
            }
            return View(games);


        }
    }
}
