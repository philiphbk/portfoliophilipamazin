using IdentityManager.Models;
using IdentityManager.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace IdentityManager.Controllers
{
    public class SkillsController : Controller
    {
        private readonly ISkillsServices _skills;

        public SkillsController(ISkillsServices skills)
        {
            _skills = skills;
        }
        public IActionResult Skills()
        {
            return View();
        }

        public IActionResult Create(Skills skills)
        {
            var skill = _skills.AddSkill(skills);
            return View(skill);
        }

        public IActionResult Update(Skills skills)
        {
            var skill = _skills.UpdateSkills(skills);
            return View(skill);
        }

        public IActionResult Delete(Skills skills)
        {
            var skill = _skills.DeleteSkill(skills);
            return View(skill);
        }
    }
}
