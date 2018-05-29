using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMainRepository.DBContext;
using WebMainRepository.Model;

namespace WebMainRepository.UoW
{
   public class EmployeeUoWRepository : IEmployeeUoWRepository
    {
        public List<Employee> GetEmployees()
        {
            try
            {
                WebMainDBContext webMainDBContext = new WebMainDBContext();
                var listofEmployees = webMainDBContext.Employees.ToList();
                return listofEmployees;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
