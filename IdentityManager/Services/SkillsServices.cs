using System.Collections.Generic;
using System.Threading.Tasks;
using IdentityManager.Data.Repository.IRepository;
using IdentityManager.Models;
using IdentityManager.Services.IServices;

namespace IdentityManager.Services
{
    public class SkillsServices: ISkillsServices
    {
        private readonly ISkillsRepository _repo;

        public SkillsServices(ISkillsRepository repo)
        {
            _repo = repo;   
        }
        public bool AddSkill(Skills skills)
        {
            _repo.Add(skills);
            return SaveSkill();
        }

        public bool DeleteSkill(Skills skills)
        {
            _repo.Delete(skills);
            return SaveSkill();
        }

        public async Task<IEnumerable<Skills>> GetAllSkills()
        {
            return await _repo.GetAll();
        }

        public async Task<Skills> GetSkillByIdAsync(int id)
        {
            return await _repo.GetByIdAsync(id);
        }

        public bool UpdateSkills(Skills skills)
        {
            _repo.Update(skills);
            return SaveSkill();
        }

        public bool SaveSkill()
        {
            var save = _repo.Save();
            return save;
        }
    }
}
