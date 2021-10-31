using NewOneRamkrishna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace NewOneRamkrishna.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            List<Employee> employeeAll = new List<Employee>();
            string maincon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            SqlConnection con = new SqlConnection(maincon);
            string querystring = "select Empno,Ename,Sal from Emp";
            SqlCommand cmd = new SqlCommand(querystring,con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Employee emp = new Employee();
                emp.id =Convert.ToInt32(dr["Empno"]);
                emp.EmpName = dr["Ename"].ToString();
                emp.salary =Convert.ToDouble( dr["Sal"]);
                employeeAll.Add(emp);
                
            
            }

           // List<Employee> li = new List<Employee>()

           // { new Employee{
           //     id = 1,
           //     EmpName = "Ramkrishna",
           //     email = "ramkrishnabhapkar@gmail.com",
           //     contact = "8380029541",
           //     salary = 50000.00

           // },
           //new Employee
           // {
           //     id = 1,
           //     EmpName = "Ramkrishna",
           //     email = "ramkrishnabhapkar@gmail.com",
           //     contact = "8380029541",
           //     salary = 50000.00

           // }
           // };
            return View(employeeAll);
        }
    }
}