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
    public class EditController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index(Guid? id)
        {
            var game = new GameModel();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"http://localhost:5000/api/game/{id}"))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    game = JsonConvert.DeserializeObject<GameModel>(apiResponse);
                }
            }

            return View(game);
        }

        [HttpPost, ActionName("Index")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditConfirmed(Guid id, [Bind("GameId,Nome,Descricao,Multiplayer,MaiorDeIdade,DataLancamento")] GameModel game)
        {
            using (var client = new HttpClient())
            {
                var serializedProduto = JsonConvert.SerializeObject(game);
                var content = new StringContent(serializedProduto, Encoding.UTF8, "application/json");
                var result = await client.PutAsync($"http://localhost:5000/api/game/{id}", content);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
