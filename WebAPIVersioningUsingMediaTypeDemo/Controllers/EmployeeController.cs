using ApiVersioningHelper;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIVersioningDemoUsingMediaType.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee(){ Id=1, FirstName="Imran", LastName="Sayani"},
             new Employee(){ Id=2, FirstName="Sunil", LastName="Sahoo"}
        };

        List<EmployeeV2> employeesV2 = new List<EmployeeV2>()
       {
           new EmployeeV2() { Id = 1, FirstName="Imran", LastName="Sayani",
               Address= { City="BLR", Country="India", PostCode="560037" , BuildingName= "maangalya suryodaya", State= "karnataka" } },
           new EmployeeV2() { Id = 2, FirstName="Sunil", LastName="Sahoo",
               Address= { City="BLR", Country="India", PostCode="560037" , BuildingName= "maangalya suryodaya", State= "karnataka" } }
       };

        [HttpGet(Name = "GetEmployees")]
        [ApiVersion("1.0")]
        public List<Employee> GetEmployeesV1() => employees;

        [HttpGet(Name = "GetEmployees")]
        [ApiVersion("2.0")]
        public List<EmployeeV2> GetEmployeesV2() => employeesV2;
    }
}
