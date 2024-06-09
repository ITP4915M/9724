using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
    public class StaffBLL
    {
        //initialize the staffDAL object
        StaffDAL staffDal = new StaffDAL();


        /// <summary>
        /// check the user input with staffid and Password whether is exits in the database,if have data return true ,otherwise return false.
        /// </summary>
        /// <param name="staffid"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public bool checkValidation(string staffid, string pwd)
        {
            if (staffDal.SelectStaffByIDPwd(staffid, pwd).Rows.Count > 0)
            {
                return true;
            }
            else 
            {
                return false;

            }
        }


        public bool addStaff(Staff staff)
        {
            int row = staffDal.InsertStaff(staff);
            if (row >0)
            {
                return true;
            }
            else
            {
                return false;
            }
            

        }


        public List<Staff> GetAllStaffs() {
            return staffDal.SelectAllStaffs();
        }

        public List<Staff> GetStaffByID(string staffId)
        {
            return staffDal.SelectStaffByStaffID(staffId);
        }

    }
}
