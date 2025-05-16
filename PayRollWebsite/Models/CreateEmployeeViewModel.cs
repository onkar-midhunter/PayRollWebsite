using Payroll.Models;
using System.ComponentModel.DataAnnotations;

namespace PayRollWebsite.Models
{
    public class CreateEmployeeViewModel
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required"),
            StringLength(50,MinimumLength = 2)]
        public string Name { get; set; }
        public string Gender { get; set; }
        [Display(Name = "Photo")]
        public IFormFile ImageUrl { get; set; }
        [DataType(DataType.Date),Display(Name = "Date Of Birth")]
        public DateTime DOB { get; set; }
        [DataType(DataType.Date), Display(Name = "Joining Date")]
        public DateTime DateJoined { get; set; } = DateTime.UtcNow;
        public string Phone { get; set; }
        [Required(ErrorMessage = "Designation is required"),
            StringLength(100)]
        public string Designation { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required,StringLength(50)]
        [RegularExpression(@"^[A-Z0-9]{8,12}$", ErrorMessage = "Insurance Number must be 8-12 characters, letters and numbers only.")]
        public string InsuranceNo { get; set; }
        [Display(Name = " Payment Method")]
        public PaymentMethod paymentMethod { get; set; }
        [Display(Name = "Student Loan")]
        public StudentLoan StudentLoan { get; set; }
        [Display(Name = "Union Member")]
        public UnionMember UnionMember { get; set; }
        [Required,StringLength(150)]

        public string Address { get; set; }
        [Required, StringLength(50)]
        public string City { get; set; }
        [Required, StringLength(50)]
        public string Postcode { get; set; }
    }
}
