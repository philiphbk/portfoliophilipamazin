using System.Collections.Generic;
using System.Threading.Tasks;
using IdentityManager.Data.Repository.IRepository;
using IdentityManager.Models;
using Microsoft.EntityFrameworkCore;

namespace IdentityManager.Data.Repository
{
    public class ProjectRepository: IProjectRepository
    {
        private readonly ApplicationDbContext _context;

        public ProjectRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Projects projects)
        {
            _context.Add(projects);
            return Save();
        }

        public bool Delete(Projects projects)
        {
            _context.Remove(projects);
            return Save();
        }

        public async Task<IEnumerable<Projects>> GetAll()
        {
            return await _context.Projects.ToListAsync();
        }

        public async Task<Projects> GetByIdAsync(int id)
        {
            return await _context.Projects.Include(i => i.Name).FirstOrDefaultAsync(i => i.Id == id);
        }

        public bool Update(Projects projects)
        {
            _context.Update(projects);
            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0;
        }
    }
}
