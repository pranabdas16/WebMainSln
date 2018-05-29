using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMainRepository.Model;
using WebMainRepository.DBContext;
using WebMainRepository.UoW;


namespace WebMainRepositoryUnitofWork
{
  public class DepartmentUoWRepository : IDepartmentUoWRepository
    {
        public List<Department> GetDepartments()
        {
            try
            {
                WebMainDBContext webMainDBContext = new WebMainDBContext();
                var listofDepartments = webMainDBContext.Departments.ToList();
                #region To add dummy data should be deleted in future...
                //List<Department> listofDepartments = new List<Department>();
                //listofDepartments.Add(new Department { Id = 011, Location = "New York", Name = "HR" });
                //listofDepartments.Add(new Department { Id = 012, Location = "Sydney", Name = "Payroll" });
                //listofDepartments.Add(new Department { Id = 013, Location = "Chicago", Name = "IT" });
                #endregion

                return listofDepartments;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
