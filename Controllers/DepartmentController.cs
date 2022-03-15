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
    public class DepartmentController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public DepartmentController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public JsonResult Get()
        {
            string connectionString = _configuration.GetConnectionString("DigitalReadiness");

            string query = @"select DepartmentId, DepartmentName from Department";
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
        [Route("GetDepartment/{deptID}")]
        public JsonResult GetDepartment(int deptID)
        {
            string connectionString = _configuration.GetConnectionString("DigitalReadiness");

            string query = @"select DepartmentId, DepartmentName from Department where DepartmentId=" + deptID;
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
        public JsonResult Post(Department dep)
        {
            string connectionString = _configuration.GetConnectionString("DigitalReadiness");

            string query = @"insert into Department(DepartmentName) values ('" + dep.DepartmentName + "')";
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
        public JsonResult Put(Department dep)
        {
            string connectionString = _configuration.GetConnectionString("DigitalReadiness");
            try
            {
                string query = @"update Department set DepartmentName='" + dep.DepartmentName + "' where DepartmentID=" + dep.DepartmentId;
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
        public JsonResult Delete(int id)
        {
            string connectionString = _configuration.GetConnectionString("DigitalReadiness");
            try
            {
                string query = @"delete from Department where DepartmentID=" + id;
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
    }
}