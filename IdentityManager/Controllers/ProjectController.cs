using System.Threading.Tasks;
using IdentityManager.Models;
using IdentityManager.Services.IServices;
using IdentityManager.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace IdentityManager.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProjectsServices _projects;

        public ProjectController(IProjectsServices projects)
        {
            _projects = projects;
        }
        public IActionResult Project()
        {
            return View();
        }

        public IActionResult Create(Projects projects)
        {
            var project = _projects.AddProject(projects);
            return View(project);
        }

        public IActionResult Update(Projects projects)
        {
            var project = _projects.UpdateProjects(projects);
            return View(project);
        }

        public IActionResult Delete(Projects projects)
        {
            var project = _projects.DeleteProject(projects);
            return View(project);
        }

    }
}
