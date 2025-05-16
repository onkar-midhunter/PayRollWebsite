using Microsoft.AspNetCore.Mvc;
using Payroll.Models;
using Payroll.Services;
using PayRollWebsite.Helper;
using PayRollWebsite.Models;
using System.Threading.Tasks;

namespace PayRollWebsite.Controllers
{
    public class EmployeeController : Controller
    {


        private IEmployeeService _empService;
        private IWebHostEnvironment webHostEnvironment;

        public EmployeeController(IEmployeeService empService, IWebHostEnvironment webHostEnvironment)
        {
            _empService = empService;
            this.webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index(int pageNumber=1,int pageSize = 5)
        {
            var vm = _empService.GetAll().
                Select(emp => ModelConverter.ModelToViewModel(emp)).ToList;
            return View(PaginationList<EmployeeViewModel>.Create(vm,pageNumber,pageSize));
        }

        [HttpGet]
        public IActionResult Create()
        {
            var vm = new CreateEmployeeViewModel();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateEmployeeViewModel vm)
        {
            if (ModelState.IsValid)
            {
               var model = ModelConverter.ViewModelToEmployee(vm);

                if(vm.ImageUrl!= null && vm.ImageUrl.Length > 0)
                {
                    var uploadDir = @"image/employee";
                   var fileName = Guid.NewGuid().ToString()+"--"+ vm.ImageUrl.FileName;
                  var path =   Path.Combine(webHostEnvironment.WebRootPath,uploadDir,
                        fileName );
                    await vm.ImageUrl.CopyToAsync(new FileStream(path, FileMode.Create));
                    model.ImageUrl = "/" + uploadDir + "/" + fileName;

                }
                // Save the model to the database
                // Redirect to a success page or another action
                await _empService.CreateEmployeeAsync(model);
                return RedirectToAction("Index");

            }
            return View(vm);
        }
    }
}
