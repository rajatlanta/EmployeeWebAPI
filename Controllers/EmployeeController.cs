using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;
using EmployeeWebAPI.Models;

namespace EmployeeWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public EmployeeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

       [HttpGet]
        public JsonResult Get()
        {
            string connectionString = _configuration.GetConnectionString("DigitalReadiness");

            string query = @"select EmployeeID, EmployeeName, D.DepartmentName as Department, Salary, Gender, PhoneNumber from Employee E inner join Department D on E.DepartmentID = D.DepartmentID";
            DataTable dataTable = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            //sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            //return dataTable;
            return new JsonResult(dataTable);
        }

        [HttpGet]
        [Route("GetEmployee/{empID}")]
        public JsonResult GetEmployee(int empID)
        {
            string connectionString = _configuration.GetConnectionString("DigitalReadiness");

            string query = @"select EmployeeID, RTRIM(EmployeeName) as EmployeeName, RTRIM(DepartmentID) as DepartmentID, RTRIM(Salary) as Salary, RTRIM(Gender) as Gender, RTRIM(PhoneNumber) as PhoneNumber from Employee where EmployeeID=" + empID;
            DataTable dataTable = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            //sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            //return dataTable;
            return new JsonResult(dataTable);
        }

        [HttpPost]
        public JsonResult Post(Employee emp)
        {
            string connectionString = _configuration.GetConnectionString("DigitalReadiness");

            string query = @"insert into Employee(EmployeeName, DepartmentID, Salary, Gender, PhoneNumber) values ('" + emp.EmployeeName + "','" + emp.DepartmentId + "','" + emp.Salary + "','" + emp.Gender + "','" + emp.PhoneNumber + "')";
            DataTable dataTable = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            //sqlCommand.CommandType = CommandType.StoredProcedure;
            int p = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return new JsonResult("Added Successfully.");
        }

        [HttpPost]
        [Route("InsertEmployee")]
        public JsonResult Insert(Employee emp)
        {
            string connectionString = _configuration.GetConnectionString("DigitalReadiness");

            string query = @"insert into Employee(EmployeeName, DepartmentID, Salary, Gender, PhoneNumber) values ('" + emp.EmployeeName + "','" + emp.DepartmentId + "','" + emp.Salary + "','" + emp.Gender + "','" + emp.PhoneNumber + "')";
            DataTable dataTable = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            //sqlCommand.CommandType = CommandType.StoredProcedure;
            int p = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return new JsonResult("Added Successfully.");
        }

        [HttpPut]
        public JsonResult Put(Employee emp)
        {
            string connectionString = _configuration.GetConnectionString("DigitalReadiness");
            try
            {
                string query = @"update Employee set EmployeeName='" + emp.EmployeeName + "',DepartmentID='" + emp.DepartmentId + "',Salary='" + emp.Salary + "',PhoneNumber='" + emp.PhoneNumber + "' where EmployeeID=" + emp.EmployeeId;
                DataTable dataTable = new DataTable();
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                //sqlCommand.CommandType = CommandType.StoredProcedure;
                int p = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                string m = ex.Message;
            }
            return new JsonResult("Updated Successfully.");
        }

        [HttpPut]
        [Route("Update")]
        public JsonResult UpdateEmployee(Employee emp)
        {
            string connectionString = _configuration.GetConnectionString("DigitalReadiness");
            try
            {
                string query = @"update Employee set EmployeeName='" + emp.EmployeeName + "',DepartmentID='"+ emp.DepartmentId + "',Salary='" + emp.Salary + "',PhoneNumber='" + emp.PhoneNumber + "' where EmployeeID=" + emp.EmployeeId;
                DataTable dataTable = new DataTable();
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                //sqlCommand.CommandType = CommandType.StoredProcedure;
                int p = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                string m = ex.Message;
            }
            return new JsonResult("Updated Successfully.");
        }

        [HttpDelete("{id}")]
        //[Route("DeleteEmployee/{id}")]
        public JsonResult Delete(int id)
        {
            string connectionString = _configuration.GetConnectionString("DigitalReadiness");
            try
            {
                string query = @"delete from Employee where EmployeeID=" + id;
                DataTable dataTable = new DataTable();
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                //sqlCommand.CommandType = CommandType.StoredProcedure;
                int p = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                string m = ex.Message;
            }
            return new JsonResult("Deleted Successfully.");
        }

        [Route("GetAllDepartmentNames")]
        public JsonResult GetAllDepartmentNames()
        {

            string connectionString = _configuration.GetConnectionString("DigitalReadiness");

            string query = @"select DepartmentName from Department";
            DataTable dataTable = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            //sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            //return dataTable;
            return new JsonResult(dataTable);
        } 
    } 
}


