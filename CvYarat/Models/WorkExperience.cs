using CvYarat.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CvYarat.Models
{
    public class WorkExperience
    {
        [Key]
        public int Id { get; set; }

        public int ClientId { get; set; }

        [Required(ErrorMessage = "Müəssisə adı daxil edilməyib")]
        public string InstitutionName { get; set; }

        [Required(ErrorMessage = "Öhtəlik daxil edilməlidir")]
        public string Commitment { get; set; }

        [Required(ErrorMessage = "Qeyd etdiyiniz müəssisədə işə başladığınız tarix daxil edilməyib ")]
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ReasonForDismissal { get; set; }

        [Required(ErrorMessage = "Uyğun pozisiya daxil edilməlidir")]
        public string PositionName { get; set; }
        public string KnowledgesAndSkills { get; set; }

        [EnumDataType(typeof(JobStatus))]
        public JobStatus Status { get; set; }

        public Client Client { get; set; }

        [Required(ErrorMessage = "Deportament seçilməyib")]
        public int DeportamentId { get; set; }
        public Deportament Deportament { get; set; }
    }
}
