using IdentityManager.Models;
using IdentityManager.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace IdentityManager.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly IExperienceServices _experience;

        public ExperienceController(IExperienceServices experience)
        {
            _experience = experience;
        }
        public IActionResult Experience()
        {
            return View();
        }

        public IActionResult Create(Experience exp)
        {
            var exper = _experience.AddExperience(exp);
            return View(exper);
        }

        public IActionResult Update(Experience exp)
        {
            var exper = _experience.UpdateExperience(exp);
            if (exper != null)
                return View("Error");
            return View(exper);
        }
        public IActionResult Delete(Experience exp)
        {
            var exper = _experience.DeleteExperience(exp);
            return View(exper);
        }
    }
}
