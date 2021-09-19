using Microsoft.AspNetCore.Http;

namespace Game.Library.Models
{
    public class GameImageModel : GameBaseModel
    {
        public IFormFile Image { get; set; }
    }
}
