using Game.Library.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Game.App.Controllers
{
    public class ListImagesController : Controller
    {
        [HttpGet("img")]
        public async Task<IActionResult> Index()
        {
            var images = new List<ImageModel>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:5000/api/game/images"))
                {
                    var apiResponse = await response.Content.ReadAsStringAsync();
                    images = JsonConvert.DeserializeObject<List<ImageModel>>(apiResponse);
                }
            }
            return View(images);
        }
    }
}
