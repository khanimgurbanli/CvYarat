
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CvYarat.Models
{
    public class EducationLevel
    {
        [Key]
        public int Id { get; set; }
        public string Level { get; set; }

        public List<Education> Education { get; set; }
    }
}
