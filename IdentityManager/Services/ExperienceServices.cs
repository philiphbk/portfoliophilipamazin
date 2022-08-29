using System.Collections.Generic;
using System.Threading.Tasks;
using IdentityManager.Data.Repository.IRepository;
using IdentityManager.Models;
using IdentityManager.Services.IServices;

namespace IdentityManager.Services
{
    public class ExperienceServices: IExperienceServices
    {
        private readonly IExperienceRepository _repo;

        public ExperienceServices(IExperienceRepository repo)
        {
            _repo = repo;
        }

        public bool AddExperience(Experience experience)
        {
            _repo.Add(experience);
            return SaveExperience();
        }

        public bool DeleteExperience(Experience experience)
        {
            _repo.Delete(experience);
            return SaveExperience();
        }

        public async Task<IEnumerable<Experience>> GetAllExperiences()
        {
            return await _repo.GetAll();
        }

        public async Task<Experience> GetExperienceByIdAsync(int id)
        {
            return await _repo.GetByIdAsync(id);
        }

        public bool UpdateExperience(Experience experience)
        {
            _repo.Update(experience);
            return SaveExperience();
        }

        public bool SaveExperience()
        {
            var save = _repo.Save();
            return save;
        }
    }
}
