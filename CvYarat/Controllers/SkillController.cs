using CvYarat.Data;
using CvYarat.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CvYarat.Controllers
{
    [Authorize]
    public class SkillController : Controller
    {
        ClientSkill  s = new();

        private readonly ILogger<SkillController> _logger;
        private readonly ApplicationDbContext db;
        public SkillController(ILogger<SkillController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            this.db = db;
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult ListOfSkill()
        {
            var getList = db.ClientSkills.Where(s => s.ClientId == db.Clients.Where(c => c.UserId == User.FindFirst(ClaimTypes.NameIdentifier).Value).FirstOrDefault().Id).ToList();
            if (getList.Count == 0)
            {
                return RedirectToAction("AddSkill");

            }
            else
            {
                return View(getList);
            }
        }


        public IActionResult AddSkill()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddSkill(ClientSkill skill)
        {
            if (!ModelState.IsValid)
            {
                return View(skill);
            }

            s.Name = skill.Name;
            s.Level = skill.Level;
            s.ClientId=db.Clients.Where(c=>c.UserId== User.FindFirst(ClaimTypes.NameIdentifier).Value).FirstOrDefault().Id;

            db.Add(s);
            db.SaveChanges();

            return RedirectToAction("ListOfSkill");
        }



        public IActionResult EditSkill(int id)
        {
            return View(db.ClientSkills.Where(s=>s.Id==id).FirstOrDefault());
        }


        [HttpPut]
        public IActionResult EditSkill(ClientSkill skill)
        {
            if (!ModelState.IsValid)
            {
                return View(skill);
            }

            var getSkillById = db.ClientSkills.Where(s=>s.Id==skill.Id).FirstOrDefault();
            getSkillById.Name = skill.Name;
            getSkillById.Level = skill.Level;

            db.Update(getSkillById);
            db.SaveChanges();

            return RedirectToAction("ListOfSkill");
        }


        
        [HttpDelete]
        public IActionResult DeleteSkill(int id)
        {
            db.Remove(db.ClientSkills.Where(s => s.Id == id).FirstOrDefault());
            db.SaveChanges();

            return RedirectToAction("ListOfSkill");
        }

    }
}
