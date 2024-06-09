using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DepartmentDAL
    {
        //創建MysqlHelper 的對象 ，CRUD 基本訪問數據方法
        DAL.MysqlHelper msh = new DAL.MysqlHelper(ConfigurationManager.ConnectionStrings["connstr"].ToString());


        /// <summary>
        /// 查詢部門數據，返回一個對象集合
        /// </summary>
        /// <returns></returns>
        public List<Department> SelectAllDepartment()
        {
            List<Department> dept = new List<Department>();
            DataTable dt = msh.ExecuteDataTable(@" SELECT  * FROM department;");
            foreach (DataRow dr in dt.Rows)
            {
                dept.Add(ToModel(dr));
            }
            return dept;

        }

        private Department ToModel(DataRow dr)
        {
            Department dept = new Department();
      
            dept.DepartmentName = dr["DepartmentName"].ToString();
            dept.DepartmentID = dr["DepartmentID"].ToString();
            return dept;
        }

    }
}
