using Game.API.Data;
using Game.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game.API.Repositories
{
    public class ImageRepository<T> : IGenericRepository<ImageModel> where T : class
    {
        private readonly AppDBContext _context;

        public ImageRepository(AppDBContext context)
        {
            _context = context;
        }

        public async Task AddAsync(ImageModel image)
        {
            await _context.AddAsync(image);
            await _context.SaveChangesAsync();
        }

        public ImageModel GetById(Guid id)
        {
            return _context.Images.FirstOrDefault(x => x.Id == id);

        }

        public IEnumerable<ImageModel> List()
        {
            return _context.Images.OrderBy(x => x.Name);
        }

        public async Task RemoveAsync(ImageModel image)
        {
            _context.Remove(image);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(ImageModel image)
        {
            var imageUpdated = _context.Images.FirstOrDefault(img => img.Id == image.Id);
            _context.Update(imageUpdated);
            await _context.SaveChangesAsync();
        }
    }
}
