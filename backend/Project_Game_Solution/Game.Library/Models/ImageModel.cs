namespace Game.Library.Models
{
    public class ImageModel : BaseModel
    {
        public string Name { get; set; }
        public byte[] Data { get; set; }
        public string ContentType { get; set; }
    }
}
