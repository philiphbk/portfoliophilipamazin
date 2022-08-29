using System.Collections.Generic;
using System.Threading.Tasks;
using IdentityManager.Data.Repository.IRepository;
using IdentityManager.Models;
using Microsoft.EntityFrameworkCore;

namespace IdentityManager.Data.Repository
{
    public class ExperienceRepository: IExperienceRepository
    {
        private readonly ApplicationDbContext _context;

        public ExperienceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Add(Experience experience)
        {
            _context.AddAsync(experience);
            return Save();
        }

        public bool Delete(Experience experience)
        {
            _context.Remove(experience);
            return Save();

        }

        public async Task<IEnumerable<Experience>> GetAll()
        {
            return await _context.Experience.ToListAsync();
        }
        public async Task<Experience> GetByIdAsync(int id)
        {
            return await _context.Experience.Include(i => i.JobRole).FirstOrDefaultAsync(i => i.Id == id);
        }

        public bool Update(Experience experience)
        {
            _context.Update(experience);
            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0;
        }
    }
}
