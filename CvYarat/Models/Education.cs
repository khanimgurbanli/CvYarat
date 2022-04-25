using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CvYarat.Models
{
    public class Education
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Təhsil müəssisəsinə daxil olduğunuz tarix seçilməyib ")]
        public DateTime? BeginDate { get; set; }



        [Required(ErrorMessage = "Təhsil müəssisəsini bitirdiyiniz tarix seçilməyib ")]
        public DateTime? EndDate { get; set; }


        [Required(ErrorMessage = "İxtisas daxil edilməyib ")]
        public string Specialty { get; set; }

        public string Point { get; set; }


        [Required(ErrorMessage = "Təhsil səviyyəsi seçilməyib ")]
        public int EducationLevelId { get; set; }
        public EducationLevel EducationLevel { get; set; }


        [Required(ErrorMessage = "Təhsil müəssisəsi seçilməyib ")]
        public int EduInstitutionId { get; set; }
        public EduInstitution EduInstitution { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
