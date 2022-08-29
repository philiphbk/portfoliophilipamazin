using System.Collections.Generic;
using System.Threading.Tasks;
using IdentityManager.Models;

namespace IdentityManager.Services.IServices
{
    public interface IExperienceServices
    {
        public bool AddExperience(Experience experience);
        public bool DeleteExperience(Experience experience);
        public Task<IEnumerable<Experience>> GetAllExperiences();
        public Task<Experience> GetExperienceByIdAsync(int id);
        public bool UpdateExperience(Experience experience);
        public bool SaveExperience();
    }
}
