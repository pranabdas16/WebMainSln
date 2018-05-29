using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMainRepository.Model;

namespace WebMainRepository.UoW
{
    public interface IDepartmentUoWRepository
    {
        List<Department> GetDepartments();
    }
}
