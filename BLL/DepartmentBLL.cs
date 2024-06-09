using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
    public  class DepartmentBLL
    {

        DepartmentDAL departmentDal = new DepartmentDAL();
        public List<Department> GetDepartments()
        {
            List<Department> depts = new List<Department>();
            depts = departmentDal.SelectAllDepartment();

            return depts;

        }
  
    
    
    
    
    
    
    
    }

}
