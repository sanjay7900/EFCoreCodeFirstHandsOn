﻿using EntityFrameWorkData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkData
{
    public class CRUDManagerForEmployee
    {
        DemoDbContext context;
        public CRUDManagerForEmployee()
        {
            context = new DemoDbContext();
        }
        public void AddEmployee(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();  

        }
        public List<Employee> showAllEmployee()
        {
            return context.Employees.ToList();
        }
        public void DeleteEmployeeById(int id)
        {
            var deleteEmp = context.Employees.Where(x => x.EmployeeId == id).FirstOrDefault();
            if (deleteEmp == null)
            {
                Console.WriteLine($"No record Found whth id  {id}");
            }
            else
            {
                context.Employees.Remove(deleteEmp);
                context.SaveChanges();
                Console.WriteLine("DELETED");
            }

        }
        public Employee GetEmployeeById(int EmployeeId)
        {
            Employee employee = new Employee();
            var emp= context.Employees.SingleOrDefault(x => x.EmployeeId == EmployeeId);
            if(emp == null)
            {
                Console.WriteLine("record Not Found {0}",EmployeeId);
                employee.EmployeeName = "not Found";

            }
            else
            {
                employee = emp;
            }

            return employee;
        }
        public void UpdateEmployee(int EmployeeId,Employee employee)
        {
            var updateemp=context.Employees.Where(x => x.EmployeeId == EmployeeId).FirstOrDefault();
            if(updateemp == null)
            {
                Console.WriteLine("no record Found with this id = {0} to be  Update ",EmployeeId);

            }
            else
            {
                updateemp.EmployeeName = employee.EmployeeName;
               updateemp.EmployeeAddress=employee.EmployeeAddress;
                context.Employees.Update(updateemp);
                context.SaveChanges();

            }
        }
    }
}
