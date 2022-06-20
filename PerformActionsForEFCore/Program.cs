using EntityFrameWorkData;
using EntityFrameWorkData.Entities;

namespace PerformActionsForEFCore
{


    public class program
    {
        public static void Main()
        {
            #region employee
            CRUDManagerForEmployee employee = new CRUDManagerForEmployee();
            employee.AddEmployee(new Employee { EmployeeName = "raj", EmployeeAddress = "Dehi" });

            var data = employee.showAllEmployee();
            foreach (var emp in data)
            {
                Console.WriteLine("Employee Name = " + emp.EmployeeName + " and Employee Address = " + emp.EmployeeAddress);
            }
            employee.UpdateEmployee(1, new Employee { EmployeeName = "Shivam Kumar", EmployeeAddress = "Aligarh" });
            employee.DeleteEmployeeById(1);
            var empdata = employee.showAllEmployee();
            foreach (var emp in empdata)
            {
                Console.WriteLine("Employee Name = " + emp.EmployeeName + " and Employee Address = " + emp.EmployeeAddress);
            }
            #endregion

            #region EmpEdu
            CRUDMamagerForEmployeEducation employeEducation = new CRUDMamagerForEmployeEducation();
            employeEducation.AddEducation(new EmployeEducation { CourseName = "BCA", UniversityName = "GLA University", PassingYear = 2022, MarksPercentage = 85, EmployeeId = 3 });

            employeEducation.AddEducation(new EmployeEducation { CourseName = "BCA", UniversityName = "GLA University", PassingYear = 2021, MarksPercentage = 85, EmployeeId = 2 });
            var edu = employeEducation.ShowAllEmpEducation();
            foreach (var employe in edu)
            {
                Console.WriteLine("Employee Id : " + employe.EmployeeId);
                Console.WriteLine("Employee Course Name : " + employe.CourseName);
                Console.WriteLine("Employee Passing Year : " + employe.PassingYear);
                Console.WriteLine("Employee PerCentage :" + employe.MarksPercentage);
                Console.WriteLine();
            }
            employeEducation.updateEdu(1, new EmployeEducation { CourseName = "B.Tech", UniversityName = "GLA University", PassingYear = 2021, MarksPercentage = 89, EmployeeId = 1 });
            edu = employeEducation.ShowAllEmpEducation();
            foreach (var employe in edu)
            {
                Console.WriteLine("Employee Id : " + employe.EmployeeId);
                Console.WriteLine("Employee Course Name : " + employe.CourseName);
                Console.WriteLine("Employee Passing Year : " + employe.PassingYear);
                Console.WriteLine("Employee PerCentage :" + employe.MarksPercentage);
                Console.WriteLine();
            }
            employeEducation.deleteEdu(2);
            edu = employeEducation.ShowAllEmpEducation();
            foreach (var employe in edu)
            {
                Console.WriteLine("Employee Id : " + employe.EmployeeId);
                Console.WriteLine("Employee Course Name : " + employe.CourseName);
                Console.WriteLine("Employee Passing Year : " + employe.PassingYear);
                Console.WriteLine("Employee PerCentage :" + employe.MarksPercentage);
                Console.WriteLine();
            }

            #endregion
            Console.ReadLine();


        }
    }
}
