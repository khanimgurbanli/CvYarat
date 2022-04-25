using CvYarat.Data;
using CvYarat.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CvYarat.Controllers
{
    public class WorkController : Controller
    {
        private readonly ApplicationDbContext db;
        public WorkController(ApplicationDbContext db)
        {
            this.db = db;
        }

        WorkExperience w=new();

        public IActionResult ListOfWorkExperiences()
        {
            List<SelectListItem> Deportaments = (from e in db.Deportaments.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = e.Name,
                                                   Value = e.Id.ToString()
                                               }).ToList();

            ViewData["Dprtmnt"] = Deportaments;


            return View(db.WorkExperiences.Where(w => w.ClientId == (db.Clients.Where(c => c.UserId == User
                   .FindFirst(ClaimTypes.NameIdentifier).Value)
               .FirstOrDefault().Id)).ToList());
        }


        public IActionResult AddWorkExperience()
        {
            List<SelectListItem> Deportaments = (from e in db.Deportaments.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = e.Name,
                                                     Value = e.Id.ToString()
                                                 }).ToList();

            ViewData["Dprtmnt"] = Deportaments;


            if (db.WorkExperiences
               .Where(e => e.ClientId == (db.Clients
               .Where(c => c.UserId == User
               .FindFirst(ClaimTypes.NameIdentifier).Value)
               .FirstOrDefault()).Id)
               .FirstOrDefault() == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("ListOfWorkExperiences");
            }

        }



        [HttpPost]
        public IActionResult AddWorkExperience(WorkExperience workExperience)
        {
            List<SelectListItem> Deportaments = (from e in db.Deportaments.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = e.Name,
                                                     Value = e.Id.ToString()
                                                 }).ToList();

            ViewData["Dprtmnt"] = Deportaments;

            if (!ModelState.IsValid)
            {
                return View("AddWorkExperience",workExperience);
            }

            w.InstitutionName = workExperience.InstitutionName;
            w.Commitment = workExperience.Commitment;
            w.BeginDate = workExperience.BeginDate;
            w.EndDate = workExperience.EndDate;
            w.ReasonForDismissal = workExperience.ReasonForDismissal;
            w.PositionName = workExperience.PositionName;
            w.KnowledgesAndSkills = workExperience.KnowledgesAndSkills;
            w.Status = workExperience.Status;
            w.ClientId = db.Clients.Where(c=>c.UserId==User.FindFirst(ClaimTypes.NameIdentifier).Value).FirstOrDefault().Id;
            w.Deportament = db.Deportaments.Where(w => w .Id== workExperience.DeportamentId).FirstOrDefault();


            db.Add(w);
            db.SaveChanges();

            return RedirectToAction("ListOfWorkExperiences");
        }

        
        public IActionResult EditWorkExperience(int id)
        {
            List<SelectListItem> Deportaments = (from e in db.Deportaments.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = e.Name,
                                                     Value = e.Id.ToString()
                                                 }).ToList();

            ViewData["Dprtmnt"] = Deportaments;

            return View(db.WorkExperiences.Where(w => w.Id == id).FirstOrDefault());
        }


        [HttpPut]
        public IActionResult EditWorkExperience(WorkExperience workExperience)
        {
            List<SelectListItem> Deportaments = (from e in db.Deportaments.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = e.Name,
                                                     Value = e.Id.ToString()
                                                 }).ToList();

            ViewData["Dprtmnt"] = Deportaments;

            if (!ModelState.IsValid)
            {
                return View(workExperience);
            }

            var getById = db.WorkExperiences.Where(w => w.Id == workExperience.Id).FirstOrDefault();

            getById.InstitutionName = workExperience.InstitutionName;
            getById.Commitment = workExperience.Commitment;
            getById.BeginDate = workExperience.BeginDate;
            getById.EndDate = workExperience.EndDate;
            getById.ReasonForDismissal = workExperience.ReasonForDismissal;
            getById.PositionName = workExperience.PositionName;
            getById.KnowledgesAndSkills = workExperience.KnowledgesAndSkills;
            getById.Status = workExperience.Status;
            getById.Deportament = db.Deportaments.Where(w => w.Id == workExperience.DeportamentId).FirstOrDefault();


            db.Update(getById);
            db.SaveChanges();

            return RedirectToAction("ListOfWorkExperiences");
        }


        [HttpDelete]
        public IActionResult DeleteWorkExperience(int id)
        {
            db.Remove(db.WorkExperiences.Where(w => w.Id == id).FirstOrDefault());
            db.SaveChanges();

            return RedirectToAction("ListOfWorkExperiences");
        }


    }
}
