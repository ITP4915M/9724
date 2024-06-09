using System;
using System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class StaffDepartmentDAL
    {
        //創建MysqlHelper 的對象 ，CRUD 基本訪問數據方法
        DAL.MysqlHelper msh = new DAL.MysqlHelper(ConfigurationManager.ConnectionStrings["connstr"].ToString());

        /// <summary>
        /// 無條件查詢員工數據（不顯示密碼），返回數據表
        /// </summary>
        /// <returns></returns>
        /// 
        public  List<StaffDepartment> SelectStaffDepartemt()
        {
            List<StaffDepartment> staffDepartments = new List<StaffDepartment>();
            DataTable dt = msh.ExecuteDataTable("SELECT StaffID, StaffName, DepartmentName,Position, Age, CNID, PhoneNo, Email, Position,staff.DepartmentID" +
                " FROM staff, department WHERE staff.DepartmentID = department.DepartmentID;");
            foreach (DataRow dr in dt.Rows) {
                staffDepartments.Add(ToModel(dr));
            }
            return staffDepartments;
        }

        private StaffDepartment ToModel(DataRow dr) {
            StaffDepartment staffDepartment = new StaffDepartment();
            staffDepartment.StaffID = dr["StaffID"].ToString();
            staffDepartment.StaffName = dr["StaffName"].ToString();
            staffDepartment.age = (int)dr["Age"];
            staffDepartment.CNID = dr["CNID"].ToString();
            staffDepartment.PhoneNo = dr["PhoneNo"].ToString();
            staffDepartment.Email = dr["Email"].ToString();
            staffDepartment.StaffID = dr["StaffID"].ToString();
            staffDepartment.DepartmentID = dr["DepartmentID"].ToString();
            staffDepartment.DepartmentName = dr["DepartmentName"].ToString();
            staffDepartment.Position = dr["Position"].ToString();
            return staffDepartment;
        }

    }
}
