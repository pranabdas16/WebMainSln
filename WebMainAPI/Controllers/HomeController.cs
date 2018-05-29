using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Unity;
using System.Web.Mvc;
using WebMainService;
using WebMainRepository.Model;
using WebMainRepository.UoW;
using WebMainRepositoryUnitofWork;

namespace WebMainAPI.Controllers
{
    public class HomeController : ApiController
    {

        private IEmployeeService oEmployeeService;
        private IEmployeeUoWRepository OIEmpUoW;
        private IDepartmentUoWRepository ObjEDepUoW;
        private UnityContainer ioc = new UnityContainer();
        //public string Index()
        //{
        //    return "Hello Web API";
        //}

        public HomeController()
        { }

        public HomeController(IEmployeeService iEmployeeService, IEmployeeUoWRepository iObjEmpUoWRep,  IDepartmentUoWRepository iObjDepUowRep)
        {
            oEmployeeService = iEmployeeService;
            OIEmpUoW = iObjEmpUoWRep;
            ObjEDepUoW = iObjDepUowRep;
        }
        public List<Employee> Get()
        {
            ioc.RegisterType<IEmployeeService, EmployeeService>();
            EmployeeService objEmployeeSrvc = ioc.Resolve<EmployeeService>();
            List<Employee> empList = objEmployeeSrvc.GetEmployees();
            return empList;
            //return new string[] { "value1", "value2" };
        }
    }
}
