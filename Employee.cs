using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
	public class Employee
	{
		[Display(Name = "ID")]
		public int ID { get; set; }

		[Display(Name = "Employee Name")]
		public string EmployeeName { get; set; }
	}

	public class Employees
	{
		private List<Employee> _employeeList;

		public Employees()
		{
			_employeeList = new List<Employee>();

			var tmpEmp = new Employee { ID = 1, EmployeeName = "Jim Nicholson" };
			_employeeList.Add(tmpEmp);
			tmpEmp = new Employee { ID = 2, EmployeeName = "Tim Nicholson" };
			_employeeList.Add(tmpEmp); 
			tmpEmp = new Employee { ID = 3, EmployeeName = "Wesley Nicholson" };
			_employeeList.Add(tmpEmp); 
			tmpEmp = new Employee { ID = 4, EmployeeName = "Dorothy Nicholson" };
			_employeeList.Add(tmpEmp); 
			tmpEmp = new Employee { ID = 5, EmployeeName = "Jeanette Nicholson" };
			_employeeList.Add(tmpEmp);
		}

		public List<Employee> EmployeesList
		{
			get { return _employeeList; }
		}
	}
}
