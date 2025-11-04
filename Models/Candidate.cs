using System.ComponentModel.DataAnnotations;

namespace Basvuru_sistemi.Models
{
    public class Candidate
    {
        [Required(ErrorMessage = "E-Mail is Required.")]
        public String? Email { get; set; } = String.Empty;
        [Required(ErrorMessage = "FirstName is Required.")]
        public String? FirstName { get; set; } = String.Empty;
        [Required(ErrorMessage = "LastName is Required.")]
        public String? LastName { get; set; } = String.Empty;
        [Required(ErrorMessage = "Age is Required.")]
        public int? Age { get; set; }

        [Required(ErrorMessage = "Course is Required.")]
        public String? SelectedCourse { get; set; } = String.Empty;

        public DateTime ApplyAt { get; set; }

        public Candidate()
        {
            ApplyAt = DateTime.Now;
        }
    }
}