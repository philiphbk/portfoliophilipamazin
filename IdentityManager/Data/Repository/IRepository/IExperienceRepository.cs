using System.Collections.Generic;
using System.Threading.Tasks;
using IdentityManager.Models;

namespace IdentityManager.Data.Repository.IRepository
{
    public interface IExperienceRepository
    {
        public bool Add(Experience experience);
        public bool Delete(Experience experience);
        public Task<IEnumerable<Experience>> GetAll();
        public Task<Experience> GetByIdAsync(int id);
        public bool Update(Experience experience);
        public bool Save();
    }
}
