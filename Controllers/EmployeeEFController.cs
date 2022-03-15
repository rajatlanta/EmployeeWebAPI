using EmployeeWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace EmployeeWebAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeEFController : ControllerBase
    {
        private readonly AppDbContext appDbContext;
        public EmployeeEFController(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        
        [HttpGet]
        [Route("GetEmployees")]
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await appDbContext.Employee.ToListAsync();
        }


       /* [HttpGet]
        [Route("GetEmployee/{empID}")]
        public async Task<Employee> GetEmployee(int empID)
        {
            return await appDbContext.Employee.SingleAsync(s => s.EmployeeId == empID);

        } */


        [HttpGet]
        [Route("GetEmployees2")]
        public JsonResult GetEmployees2()
        {
            var p = appDbContext.Department 
                        .Include(s => s.Employee)
                        .ToList();

            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            };

            var jsonString = JsonConvert.SerializeObject(p, settings);

            ICollection<Department> dept = appDbContext.Department 
                    .ToList();

            return new JsonResult(jsonString);
        }

        [HttpGet]
        [Route("GetEmployees3")]
        public string GetEmployees3()
        {
            var p = appDbContext.Department 
                        .Include(s => s.Employee)
                        .ToList();
            
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            };

            string jsonString = JsonConvert.SerializeObject(p, settings);

            jsonString = jsonString.Replace("\\\\", "");

            ICollection<Department> dept = appDbContext.Department //.Where(s => s.DepartmentID == 1)
                    .ToList();

            return jsonString;
        }

        [HttpGet]
        public JsonResult Get()
        {
            var query = from b in appDbContext.Set<Employee>()
                        join p in appDbContext.Set<Department>()
                            on b.DepartmentId equals p.DepartmentId 
                        select new { EmployeeID = b.EmployeeId, b.EmployeeName, Department = p.DepartmentName, b.Salary, b.Gender, b.PhoneNumber  };

            return new JsonResult(query);

            //select EmployeeID, EmployeeName, D.DepartmentName as Department, Salary, Gender, PhoneNumber
        }

        [HttpGet]
        [Route("GetEmployee/{empID}")]
        public JsonResult GetEmployee(int empID)
        {
            var query = from b in appDbContext.Set<Employee>()
                        join p in appDbContext.Set<Department>()
                            on b.DepartmentId equals p.DepartmentId where b.EmployeeId == empID
                        select new { EmployeeID = b.EmployeeId, b.EmployeeName, DepartmentID = p.DepartmentId, b.Salary, b.Gender, b.PhoneNumber };

            return new JsonResult(query);
        }

        [HttpPut]
        public JsonResult Put(Employee emp)
        {
            appDbContext.Update(emp);
            appDbContext.SaveChanges();
            return new JsonResult("Updated Successfully.");
        }

        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            Employee emp = appDbContext.Employee.Where(d => d.EmployeeId == id).FirstOrDefault();
            appDbContext.Employee.Remove(emp);
            appDbContext.SaveChanges();

            return new JsonResult("Deleted Successfully.");
        }

        [HttpPost]
        //[Route("InsertEmployee")]
        public JsonResult Post(Employee emp)
        {
            emp.EmployeeId = 0;
            appDbContext.Add(emp);
            appDbContext.SaveChanges();
            return new JsonResult("Added Successfully.");
        }



    }
}
