using Payroll.Models;
using PayRollWebsite.Models;

namespace PayRollWebsite.Helper
{
    public class ModelConverter
    {
        public static Employee ViewModelToEmployee(CreateEmployeeViewModel vm)
        {
            return new Employee
            {
                Id = vm.Id,
                Name = vm.Name,
                Gender = vm.Gender,
                Email = vm.Email,
                Phone = vm.Phone,
                DOB = vm.DOB,
                DateJoined = vm.DateJoined,
                InsuranceNo = vm.InsuranceNo,
                paymentMethod = vm.paymentMethod,
                studentLoan = vm.StudentLoan,
                UnionMember = vm.UnionMember,
                Address = vm.Address,
                City = vm.City,
                Postcode = vm.Postcode,
                Designation = vm.Designation


            };
        }

        public static EmployeeViewModel ModelToViewModel(Employee model)
        {
            return new EmployeeViewModel
            {

                Id = model.Id,
                ImageUrl = model.ImageUrl,
                Name = model.Name,
                Gender = model.Gender,
                Designation = model.Designation,
                City = model.City,
                DateJoined = model.DateJoined,





            };
        }

    }
}
