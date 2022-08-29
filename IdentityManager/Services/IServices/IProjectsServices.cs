using System.Collections.Generic;
using System.Threading.Tasks;
using IdentityManager.Models;

namespace IdentityManager.Services.IServices
{
    public interface IProjectsServices
    {
        public bool AddProject(Projects projects);
        public bool DeleteProject(Projects projects);
        public Task<IEnumerable<Projects>> GetAllProjects();
        public Task<Projects> GetProjectByIdAsync(int id);
        public bool UpdateProjects(Projects projects);
        public bool SaveProject();
    }
}
