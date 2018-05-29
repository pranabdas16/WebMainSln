using System.Collections.Generic;
using Unity;
using WebMainRepository.Model;
using WebMainRepository.UoW;
using WebMainRepositoryUnitofWork;

namespace WebMainService
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeUoWRepository OIEmpUoW;
        private IDepartmentUoWRepository ObjEDepUoW;
        private UnityContainer ioc = new UnityContainer();

        public EmployeeService()
        {
        }

        public EmployeeService(IEmployeeUoWRepository iObjEmpUoWRep, object iObjEmpUoWRep1, IDepartmentUoWRepository iObjDepUowRep)
        {
            OIEmpUoW = iObjEmpUoWRep;
            ObjEDepUoW = iObjDepUowRep;

            ioc.RegisterType<IEmployeeUoWRepository, EmployeeUoWRepository>();
            ioc.RegisterType<IDepartmentUoWRepository, DepartmentUoWRepository>();
        }

        public List<Employee> GetEmployees()
        {
            EmployeeUoWRepository objDepUoW = ioc.Resolve<EmployeeUoWRepository>();
            List<Employee> objDep = objDepUoW.GetEmployees();
            return objDep;
        }
    }
}