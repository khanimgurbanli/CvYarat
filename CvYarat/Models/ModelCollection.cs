using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CvYarat.Models
{
    public class ModelCollection
    {
        public Client Client { get; set; }
        public List<Education> Educations { get; set; }
        public List<ClientTraining> ClientTrainings { get; set; }
        public List<ClientSkill> ClientSkills { get; set; }
        public List<WorkExperience> WorkExperiences { get; set; }
    }
}
