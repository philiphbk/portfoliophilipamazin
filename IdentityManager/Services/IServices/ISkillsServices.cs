using System.Collections.Generic;
using System.Threading.Tasks;
using IdentityManager.Models;

namespace IdentityManager.Services.IServices
{
    public interface ISkillsServices
    {
        public bool AddSkill(Skills skills);
        public bool DeleteSkill(Skills skills);
        public Task<IEnumerable<Skills>> GetAllSkills();
        public Task<Skills> GetSkillByIdAsync(int id);
        public bool UpdateSkills(Skills skills);
        public bool SaveSkill();
    }
}
