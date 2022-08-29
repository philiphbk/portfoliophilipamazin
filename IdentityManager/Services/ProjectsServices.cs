using System.Collections.Generic;
using System.Threading.Tasks;
using IdentityManager.Data.Repository.IRepository;
using IdentityManager.Models;
using IdentityManager.Services.IServices;

namespace IdentityManager.Services
{
    public class ProjectsServices: IProjectsServices
    {
        private readonly IProjectRepository _repo;

        public ProjectsServices(IProjectRepository repo)
        {
            _repo = repo;
        }

        public bool AddProject(Projects projects)
        {
            _repo.Add(projects);
            return SaveProject();
        }

        public bool DeleteProject(Projects projects)
        {
            _repo.Delete(projects);
            return SaveProject();
        }

        public async Task<IEnumerable<Projects>> GetAllProjects()
        {
            return await _repo.GetAll();
        }

        public async Task<Projects> GetProjectByIdAsync(int id)
        {
            return await _repo.GetByIdAsync(id);
        }

        public bool UpdateProjects(Projects projects)
        {
            _repo.Update(projects);
            return SaveProject();
        }

        public bool SaveProject()
        {
            var save = _repo.Save();
            return save;
        }
    }
}
