using DatabaseProject.Interfaces;
using DatabaseProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseProject.DatabaseContext;

namespace DatabaseProject.Repositories
{
	public class EmployeeRepository : IEmployeeRepository
	{
		private readonly SqlServerContext _SqlServerContext;

		public EmployeeRepository(SqlServerContext sqlServerContext)
		{
			_SqlServerContext = sqlServerContext;
		}

		public List<Employee> GetEmployee()
		{
			var lstEmployees = _SqlServerContext.Employee.ToList();
			return lstEmployees;
		}

		public Employee GetEmployeeById(int id)
		{
			var employee = _SqlServerContext.Employee.FirstOrDefault(x => x.EmployeeId== id);
			return employee;
		}

		public Employee AddEmployee(Employee employee)
		{
			_SqlServerContext.Employee.Add(employee);
			_SqlServerContext.SaveChanges();
			return employee;
		}

		public List<Employee> GetEmployees()
		{
			throw new NotImplementedException();
		}

		//public List<Employee> GetEmployees()
		//{
		//throw new NotImplementedException();
	}
	}
