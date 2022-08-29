using System.Collections.Generic;
using System.Threading.Tasks;
using IdentityManager.Models;

namespace IdentityManager.Data.Repository.IRepository
{
    public interface IProjectRepository
    {
        public bool Add(Projects projects);
        public bool Delete(Projects projects);
        public Task<IEnumerable<Projects>> GetAll();
        public Task<Projects> GetByIdAsync(int id);
        public bool Update(Projects projects);
        public bool Save();
    }
}
