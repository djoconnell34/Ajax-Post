using Ajax4.Data;
using Ajax4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Ajax4.Controllers
{
    public class EmployeeController : Controller
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-HPFIADMV;Initial Catalog=AAAAjax4;Integrated Security=True");
        EmployeeDbContext _db;
        public EmployeeController(EmployeeDbContext db)
        {
             _db = db;
        }


        public async Task<IActionResult> Index()
        {
            return View(await _db.employees.ToListAsync());
        }

        [HttpPost]
        public JsonResult AjaxEmployee(string a, string b, string c, string d)
        {
            Employee emp = new Employee
            {
                EmpName = a,
                Designation = b,
                Salary = Convert.ToDouble(c),
                Address = d,
            };

            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into employees (EmpName, Designation, Salary, Address)  values ('" + emp.EmpName + "' , '" + emp.Designation + "', '" + emp.Salary + "', '" + emp.Address + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            return Json(emp);
        }
    }
}
