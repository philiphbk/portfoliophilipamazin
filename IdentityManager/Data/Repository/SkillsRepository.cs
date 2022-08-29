using System.Collections.Generic;
using System.Threading.Tasks;
using IdentityManager.Data.Repository.IRepository;
using IdentityManager.Models;
using Microsoft.EntityFrameworkCore;

namespace IdentityManager.Data.Repository
{
    public class SkillsRepository: ISkillsRepository
    {
        private readonly ApplicationDbContext _context;

        public SkillsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Add(Skills skills)
        {
            _context.Add(skills);
            return Save();
        }

        public bool Delete(Skills skills)
        {
            _context.Remove(skills);
            return Save();
        }

        public async Task<IEnumerable<Skills>> GetAll()
        {
            return await _context.Skills.ToListAsync();
        }

        public async Task<Skills> GetByIdAsync(int id)
        {
            return await _context.Skills.Include(i => i.name).FirstOrDefaultAsync(i => i.Id == id);
        }

        public bool Update(Skills skills)
        {
            _context.Update(skills);
            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0;
        }
    }
}
