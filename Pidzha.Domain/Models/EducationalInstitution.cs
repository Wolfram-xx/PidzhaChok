using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pidzha.Domain.Models
{
    public class EducationalInstitution
    {
        public string Name { get; set; }
        public string Address { get; set; }
        // Other properties as needed

        // Relationships
        public ICollection<EducationalPlan> EducationalPlans { get; set; }
    }
}
