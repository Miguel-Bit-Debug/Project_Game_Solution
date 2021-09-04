using Microsoft.AspNetCore.Http;

namespace Game.Library.Models
{
    public class GameImageModel : GameBaseModel
    {
        public string Name { get; set; }
        public IFormFile Image { get; set; }
    }
}
