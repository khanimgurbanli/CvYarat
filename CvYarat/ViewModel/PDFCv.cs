using CvYarat.Data.Enums;
using CvYarat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CvYarat.ViewModel
{
    public class PDFCv
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public string ClientName { get; set; }
        public string ClientSurname { get; set; }
        public string ClientFatherName { get; set; }
        public SelectGender ClientGender { get; set; }
        public DateTime ClientBirthdate { get; set; }
        public string Photo { get; set; }
        public int? StatusId { get; set; }
        public StatusRole StatusRole { get; set; }
        public MrtlStatus MaritalStatus { get; set; }
        public string Citizenship { get; set; }
        public string Mail { get; set; }
        public DrvgLicense DrivingLicense { get; set; }
        public MltryService MilitaryService { get; set; }
        public string LivingAddress { get; set; }
        public string RegistrationAddress { get; set; }
        public string MobPhone { get; set; }
        public string Linkedin { get; set; }
        public string Github { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public string Action { get; set; }
 //skill
        public string SkillName { get; set; }
        public string SkillLevel { get; set; }

  //trainings

        public string TrName { get; set; }
        public string TrNameSurname { get; set; }
        public string TrTel { get; set; }
        public string TrMail { get; set; }
        public string Certification { get; set; }
        public string Instition { get; set; }
        public string Address { get; set; }
        public DateTime? ProfBeginDate { get; set; }

        public DateTime? ProfEndDate { get; set; }
        public string Note { get; set; }

        //educations

        public DateTime? EduBeginDate { get; set; }

        public DateTime? EduEndDate { get; set; }

        public string Specialty { get; set; }

        public string Point { get; set; }
        public int EducationLevelId { get; set; }
        public EducationLevel EducationLevel { get; set; }
        public int EduInstitutionId { get; set; }
        public EduInstitution EduInstitution { get; set; }

        //workexperience
        public string InstitutionName { get; set; }

        public string Commitment { get; set; }
        public DateTime WorkBeginDate { get; set; }
        public DateTime WorkEndDate { get; set; }
        public string ReasonForDismissal { get; set; }
        public string PositionName { get; set; }
        public string KnowledgesAndSkills { get; set; }
        public JobStatus Status { get; set; }
        public Client Client { get; set; }
        public int DeportamentId { get; set; }
        public Deportament Deportament { get; set; }

    }
}
