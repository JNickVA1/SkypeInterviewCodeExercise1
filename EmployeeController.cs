using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeesController : Controller
    {
		private Employees _employees = new Employees();

        // GET: Employees
		public ActionResult Index()
		{
			return View(_employees.EmployeesList);
		}
    }
}
