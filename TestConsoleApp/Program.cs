using System;
using WebMainRepository.UoW;
using WebMainRepositoryUnitofWork;
using WebMainService;
using WebMainAPI.Controllers;


namespace TestConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Code is running...");
            DepartmentUoWRepository ObjDeptUoW = new DepartmentUoWRepository();
            EmployeeUoWRepository objEmpUow = new EmployeeUoWRepository();
            var listOfDepartment = ObjDeptUoW.GetDepartments();

            foreach (var item in listOfDepartment)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("\n");
            var listOfEmployees = objEmpUow.GetEmployees();
            foreach (var item in listOfEmployees)
            {
                Console.WriteLine(item.FirstName + ' ' + item.LastName);
            }
            Console.WriteLine("\n");

            EmployeeService objEmpService = new EmployeeService();
            var listOfDepartment1 = objEmpService.GetEmployees();
            foreach (var item in listOfDepartment1)
            {
                Console.WriteLine(item.FirstName + ' ' + item.LastName);
            }

            //HomeController objHomeController = new HomeController();
            //var str = objHomeController.Get();

            Console.ReadLine();
        }
    }
}