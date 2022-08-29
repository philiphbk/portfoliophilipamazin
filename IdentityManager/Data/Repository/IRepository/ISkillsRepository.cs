using System.Collections.Generic;
using System.Threading.Tasks;
using IdentityManager.Models;

namespace IdentityManager.Data.Repository.IRepository
{
    public interface ISkillsRepository
    {
        public bool Add(Skills skills);
        public bool Delete(Skills skills);
        public Task<IEnumerable<Skills>> GetAll();
        public Task<Skills> GetByIdAsync(int id);
        public bool Update(Skills skills);
        public bool Save();
    }
}
