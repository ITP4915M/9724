using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;

namespace BLL
{
    public class StaffDepartmentBLL
    {

        StaffDepartmentDAL staffDepartmentDal = new StaffDepartmentDAL();
        /// <summary>
        /// get a staffDepartment list without any  condintion 
        /// </summary>
        /// <returns></returns>
        public List<StaffDepartment> GetStaffDepartmentsList() 
        {
            

            List<StaffDepartment> staffDepartments = new List<StaffDepartment>();
            staffDepartments = staffDepartmentDal.SelectStaffDepartemt();

            return staffDepartments;


        }

    }
}
