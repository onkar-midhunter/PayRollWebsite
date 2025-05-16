using Microsoft.EntityFrameworkCore;
using Payroll.Models;
using Payroll.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Services.Implementation
{
    public class EmployeeService : IEmployeeService
    {

        private ApplicationDbContext _context;

        public EmployeeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreateEmployeeAsync(Employee employee)
        {
           await _context.Employees.AddAsync(employee);
           await _context.SaveChangesAsync();  

        }

        public IEnumerable<Employee> GetAll()
        {
          return   _context.Employees.AsNoTracking().OrderBy(x => x.Name).ToList();
        }
    }
}
