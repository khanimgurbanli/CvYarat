using CvYarat.Data;
using CvYarat.Models;
using CvYarat.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CvYarat.Controllers
{
    [Authorize]
    public class EducationController : Controller
    {
        Education e = new();
        AddCertificationImage add = new();
        EditCertificationImage edit = new();
        ClientTraining training = new();

        private readonly ApplicationDbContext db;
        public EducationController(ApplicationDbContext db)
        {
            this.db = db;
        }



        public IActionResult CreateEdu(int id)
        {


            List<SelectListItem> getInstitution = (from e in db.EduInstitutions.ToList()
                                                   select new SelectListItem
                                                   {
                                                       Text = e.Name,
                                                       Value = e.Id.ToString()
                                                   }).ToList();

            ViewData["Institution"] = getInstitution;


            List<SelectListItem> GetRduİnst = (from e in db.EducationLevels.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = e.Level,
                                                   Value = e.Id.ToString()
                                               }).ToList();
            ViewData["EduLevel"] = GetRduİnst;


            if (db.Educations
               .Where(e => e.ClientId == (db.Clients
               .Where(c => c.UserId == User
               .FindFirst(ClaimTypes.NameIdentifier).Value)
               .FirstOrDefault()).Id)
               .FirstOrDefault() == null || id != default)
            {
                return View();
            }
            else
            {
                return RedirectToAction("GetListEdu");
            }

        }


        [HttpPost]
        public IActionResult CreateEdu(Education education)
        {

            List<SelectListItem> getInstitution = (from e in db.EduInstitutions.ToList()
                                                   select new SelectListItem
                                                   {
                                                       Text = e.Name,
                                                       Value = e.Id.ToString()
                                                   }).ToList();

            ViewData["Institution"] = getInstitution;


            List<SelectListItem> GetRduİnst = (from e in db.EducationLevels.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = e.Level,
                                                   Value = e.Id.ToString()
                                               }).ToList();

            ViewData["EduLevel"] = GetRduİnst;



            if (!ModelState.IsValid)
            {
                return View("CreateEdu", education);
            }


            var checkEdu = db.Educations.ToList()
              .Any(e => e.BeginDate == education.BeginDate
                 && e.EndDate == education.EndDate
                  && e.Specialty == education.Specialty
                  && e.EducationLevel == db.EducationLevels.Where(e => e.Id == education.EducationLevelId).FirstOrDefault()
                  && e.EduInstitution == db.EduInstitutions.Where(e => e.Id == education.EduInstitutionId).FirstOrDefault()
                  && e.Point == education.Point
                  && e.ClientId == db.Clients.Where(c => c.UserId == User.FindFirst(ClaimTypes.NameIdentifier).Value).FirstOrDefault().Id);


            if (checkEdu)
            {
                ViewBag.checkResultMessage = "Daxil edilən məlumatlar artıq mövcuddur";
                return RedirectToAction("CreateEdu");
            }
            else
            {
                e.EndDate = education.EndDate;
                e.BeginDate = education.BeginDate;
                e.Specialty = education.Specialty;
                e.Point = education.Point;
                e.EducationLevel = db.EducationLevels.Where(e => e.Id == education.EducationLevelId).FirstOrDefault();
                e.EduInstitution = db.EduInstitutions.Where(e => e.Id == education.EduInstitutionId).FirstOrDefault();
                e.ClientId = db.Clients.Where(c => c.UserId == User.FindFirst(ClaimTypes.NameIdentifier).Value).FirstOrDefault().Id;

                db.Add(e);
                db.SaveChanges();

                return RedirectToAction("GetListEdu");
            }
        }



        public IActionResult EditEdu(int id)
        {

            List<SelectListItem> getInstitution = (from e in db.EduInstitutions.ToList()
                                                   select new SelectListItem
                                                   {
                                                       Text = e.Name,
                                                       Value = e.Id.ToString()
                                                   }).ToList();

            ViewData["Institution"] = getInstitution;


            List<SelectListItem> GetEduInst = (from e in db.EducationLevels.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = e.Level,
                                                   Value = e.Id.ToString()
                                               }).ToList();

            ViewData["EduLevel"] = GetEduInst;

            return View(db.Educations.Where(e => e.Id == id).FirstOrDefault());
        }



        [HttpPut]
        public IActionResult EditEdu(Education education)
        {

            List<SelectListItem> getInstitution = (from e in db.EduInstitutions.ToList()
                                                   select new SelectListItem
                                                   {
                                                       Text = e.Name,
                                                       Value = e.Id.ToString()
                                                   }).ToList();

            ViewData["Institution"] = getInstitution;


            List<SelectListItem> GetEduInst = (from e in db.EducationLevels.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = e.Level,
                                                   Value = e.Id.ToString()
                                               }).ToList();

            ViewData["EduLevel"] = GetEduInst;

            var getResultById = db.Educations.Where(e => e.Id == education.Id).FirstOrDefault();

            getResultById.EndDate = education.EndDate;
            getResultById.BeginDate = education.BeginDate;
            getResultById.Specialty = education.Specialty;
            getResultById.Point = education.Point;
            getResultById.EducationLevel = db.EducationLevels.Where(e => e.Id == education.EducationLevelId).FirstOrDefault();
            getResultById.EduInstitution = db.EduInstitutions.Where(e => e.Id == education.EduInstitutionId).FirstOrDefault();

            db.Update(getResultById);
            db.SaveChanges();

            return RedirectToAction("GetListEdu");
        }




        [HttpDelete]
        public IActionResult DeleteEdu(int id)
        {

            List<SelectListItem> getInstitution = (from e in db.EduInstitutions.ToList()
                                                   select new SelectListItem
                                                   {
                                                       Text = e.Name,
                                                       Value = e.Id.ToString()
                                                   }).ToList();

            ViewData["Institution"] = getInstitution;


            List<SelectListItem> GetEduInst = (from e in db.EducationLevels.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = e.Level,
                                                   Value = e.Id.ToString()
                                               }).ToList();

            ViewData["EduLevel"] = GetEduInst;

            var deleteByid = db.Educations
               .Where(e => e.Id == id)
               .FirstOrDefault();

            db.Remove(deleteByid);
            db.SaveChanges();

            return RedirectToAction("GetListEdu");
        }



        [HttpGet]
        public IActionResult GetListEdu()
        {

            List<SelectListItem> getInstitution = (from e in db.EduInstitutions.ToList()
                                                   select new SelectListItem
                                                   {
                                                       Text = e.Name,
                                                       Value = e.Id.ToString()
                                                   }).ToList();

            ViewData["Institution"] = getInstitution;


            List<SelectListItem> GetEduInst = (from e in db.EducationLevels.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = e.Level,
                                                   Value = e.Id.ToString()
                                               }).ToList();

            ViewData["EduLevel"] = GetEduInst;


            var getAll = db.Educations
               .Where(e => e.ClientId == (db.Clients
               .Where(c => c.UserId == User
               .FindFirst(ClaimTypes.NameIdentifier).Value)
               .FirstOrDefault().Id)).ToList();

            return View(getAll);
        }



        public IActionResult CreateProfDevp(int id )
        {
            if (db.ClientTrainings
             .Where(e => e.ClientId == (db.Clients
             .Where(c => c.UserId == User
             .FindFirst(ClaimTypes.NameIdentifier).Value)
             .FirstOrDefault()).Id)
             .FirstOrDefault() == null || id != default) 
            {
                return View();
            }
            else
            {
                return RedirectToAction("GetListTraining");
            }
        }




        [HttpPost]
        public IActionResult CreateProfDevp(AddCertificationImage addCertification)
        {


            if (!ModelState.IsValid)
            {
                return View("CreateProfDevp", addCertification);
            }
            else
            {

                if (addCertification.CertificatFile != null)
                {

                    var extension = Path.GetExtension(addCertification.CertificatFile.FileName);
                    var newImageName = Guid.NewGuid() + extension;
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/", newImageName);
                    var fileStream = new FileStream(filePath, FileMode.Create);
                    addCertification.CertificatFile.CopyTo(fileStream);
                    training.Certification = newImageName;
                }

                training.Name = addCertification.Name;
                training.NameSurname = addCertification.NameSurname;
                training.Tel = addCertification.Tel;
                training.Mail = addCertification.Mail;
                training.Instition = addCertification.Instition;
                training.Address = addCertification.Address;
                training.ProfBeginDate = addCertification.ProfBeginDate;
                training.ProfEndDate = addCertification.ProfEndDate;
                training.Note = addCertification.Note;
                training.Mail = addCertification.Mail;
                training.ClientId = (db.Clients
                    .Where(cl => cl.UserId == User
                    .FindFirst(ClaimTypes.NameIdentifier).Value).FirstOrDefault()).Id;



                db.Add(training);
                db.SaveChanges();

                return RedirectToAction("GetListTraining");
            }
        }


        public IActionResult EditProfDevp(int id)
        {

            var forEdit = db.ClientTrainings.Where(p => p.Id == id).FirstOrDefault();

            edit.Name = forEdit.Name;
            edit.NameSurname = forEdit.NameSurname;
            edit.Tel = forEdit.Tel;
            edit.Mail = forEdit.Mail;
            edit.Photo = forEdit.Certification;
            edit.Instition = forEdit.Instition;
            edit.Address = forEdit.Address;
            edit.ProfBeginDate = forEdit.ProfBeginDate;
            edit.ProfEndDate = forEdit.ProfEndDate;
            edit.Note = forEdit.Note;
            edit.Mail = forEdit.Mail;

            return View(edit);
        }


        [HttpPut]
        public IActionResult EditProfDevp(EditCertificationImage editCertification )
        {

            if (!ModelState.IsValid)
            {
                editCertification.Photo = db.ClientTrainings.Where(t => t.Id == editCertification.Id).FirstOrDefault().Certification;
                return View("EditProfDevp", editCertification);
            }

            var getById = db.ClientTrainings
                .Where(e => e.Id == editCertification.Id).FirstOrDefault();

            if (editCertification.CertificatFile != null)
            {
                var extension = Path.GetExtension(editCertification.CertificatFile.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/", newImageName);
                var fileStream = new FileStream(filePath, FileMode.Create);
                editCertification.CertificatFile.CopyTo(fileStream);
                getById.Certification = newImageName;
            }

            getById.Name = editCertification.Name;
            getById.NameSurname = editCertification.NameSurname;
            getById.Tel = editCertification.Tel;
            getById.Mail = editCertification.Mail;
            getById.Instition = editCertification.Instition;
            getById.Address = editCertification.Address;
            getById.ProfBeginDate = editCertification.ProfBeginDate;
            getById.ProfEndDate = editCertification.ProfEndDate;
            getById.Note = editCertification.Note;
            getById.Mail = editCertification.Mail;

            db.Update(getById);
            db.SaveChanges();

            return RedirectToAction("GetListTraining");
        }

        [HttpDelete]
        public IActionResult DeleteProfDevp(int id)
        {
            var deleteByid = db.ClientTrainings
               .Where(e => e.Id == id)
               .FirstOrDefault();

            db.Remove(deleteByid);
            db.SaveChanges();

            return RedirectToAction("GetListTraining");
        }

        public IActionResult GetListTraining()
        {

            var getAllTrainingList = db.ClientTrainings
               .Where(e => e.ClientId == (db.Clients
               .Where(c => c.UserId == User
               .FindFirst(ClaimTypes.NameIdentifier).Value)
               .FirstOrDefault().Id)).ToList();

            return View(getAllTrainingList);
        }

    }
}

