using Payroll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Services
{
    public interface IEmployeeService
    {
        Task CreateEmployeeAsync(Employee employee);
        IEnumerable<Employee> GetAll();
    }
}
