using Game.App.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Game.App.Controllers
{
    public class DeleteController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index(Guid id)
        {
            var game = new GameModel();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync($"http://localhost:6000/api/game/{id}"))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    game = JsonConvert.DeserializeObject<GameModel>(apiResponse);
                }
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
