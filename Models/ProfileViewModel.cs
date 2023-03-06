using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace GraduateProject.Models
{
    public class ProfileViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        [DisplayName("Date of Birth")]
        public string DOB { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public ProfileViewModel()
        {
            Name = "Melo";
            Surname = "Ball";
            DOB = "2001/08/22";
            Age = 21;
            Country = "America";
            City = "Anahiem";
        }
    }


}
