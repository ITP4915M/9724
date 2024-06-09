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
    public class StaffDAL
    {
        //創建MysqlHelper 的對象 ，CRUD 基本訪問數據方法
        DAL.MysqlHelper msh = new DAL.MysqlHelper(ConfigurationManager.ConnectionStrings["connstr"].ToString());
        IDSelfIncreasementHelper idIncrease = new IDSelfIncreasementHelper();

        /// <summary>
        /// 添加員工數據,返回受影響行數
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public int InsertStaff(Staff st) {
                int row = msh.ExecuteNonQuery("INSERT INTO staff (StaffID,StaffName,DepartmentID,Age,Password,CNID,PhoneNo,Email,Position) VALUES (@StaffID,@StaffName,@DepartmentID,@Age,@Password,@CNID,@PhoneNo,@Email ,@Position)",
                new MySqlParameter("@StaffID", st.StaffID),
                new MySqlParameter("@StaffName", st.StaffName),
                new MySqlParameter("@DepartmentID", st.DepartmentID),
                new MySqlParameter("@Age", st.Age),
                new MySqlParameter("@Password", st.Password),
                new MySqlParameter("@CNID", st.CNID),
                new MySqlParameter("@PhoneNo", st.PhoneNo),
                new MySqlParameter("@Email", st.Email),
                new MySqlParameter("@Position", st.Position)
                );
            return row;


        }
        private string GetNextCharId()
        {
            string lastId = idIncrease.QueryDatabaseForLastCharId();
            long numericPart = long.Parse(lastId);
            numericPart++;
            string newId = numericPart.ToString();
            return newId;
        }


        /// <summary>
        ///   //刪除所有員工數據
        /// </summary>
        public void DeleteStaff() {
            msh.ExecuteNonQuery(@"DELETE FROM staff");
        
        }

        /// <summary>
        /// 刪除員工By staffID
        /// </summary>
        /// <param name="StaffID"></param>
        public void DeleteStaffByID(int StaffID) {
            msh.ExecuteNonQuery(@"DELETE FROM staff WHERE StaffID = @StaffID", new MySqlParameter("@StaffID", StaffID));
        }



        //根據StaffID更新員工數據
        public void UpdateStaff(Staff st) {
            msh.ExecuteNonQuery("UPDATE staff SET  " +
                "StaffID=@StaffID,StaffName = @StaffName,DepartmentID=@DepartmentID," +
                "Age=@Age,Password=@Password,CNID=@CNID, PhoneNo=@PhoneNo,Email=@Email, Position = @Position WHERE StaffID = @StaffID",
            new MySqlParameter("@StaffID", st.StaffID),
            new MySqlParameter("@StaffName", st.StaffName),
            new MySqlParameter("@DepartmentID", st.DepartmentID),
            new MySqlParameter("@Age", st.Age),
            new MySqlParameter("@Password", st.Password),
            new MySqlParameter("@CNID", st.CNID),
            new MySqlParameter("@PhoneNo", st.PhoneNo),
            new MySqlParameter("@Email", st.Email),
            new MySqlParameter("@Position", st.Position)
          );
        
        }


        /// <summary>
        /// 查詢員工所有數據
        /// </summary>
        /// <returns></returns>
        public List<Staff> SelectAllStaffs() {
            List<Staff> st = new List<Staff>();
            DataTable dt = msh.ExecuteDataTable(@"SELECT * FROM staff");
            foreach (DataRow dr in dt.Rows) {
                st.Add(ToModel(dr));
            }
            return st;
        
        }

        /// <summary>
        /// 用staffID 查詢某個員工數據 ，返回對象集合
        /// </summary>
        /// <param name="StaffID"></param>
        /// <returns></returns>
        public List <Staff> SelectStaffByStaffID(string StaffID)
        {
            List<Staff> st = new List<Staff>();
            DataTable dt = msh.ExecuteDataTable(@"SELECT * FROM staff WHERE StaffID = @StaffID", new MySqlParameter("@StaffID", StaffID));
            foreach (DataRow dr in dt.Rows)
            {
                st.Add(ToModel(dr));
            }
            return st;

        }

        /// <summary>
        /// 將數據表的行數據，轉為數據對象
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        private Staff ToModel(DataRow dr) {
            Staff st = new Staff();
            st.StaffID = dr["StaffID"].ToString();
            st.StaffName = dr["StaffName"].ToString();
            st.DepartmentID = dr["DepartmentID"].ToString();
            st.Age = (int)dr["Age"];
            st.Password = dr["Password"].ToString();
            st.CNID = dr["CNID"].ToString();
            st.PhoneNo = dr["PhoneNo"].ToString();
            st.Email = dr["Email"].ToString();
            st.Position = dr["Position"].ToString();
            
            return st;
        }


        /// <summary>
        ///用StaffID 和 密碼  查詢某個員工訊息，返回數據表
        /// </summary>
        /// <param name="staffID"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public DataTable SelectStaffByIDPwd(string staffID, string pwd) {
            string sql = "SELECT * FROM staff Where StaffID = @StaffID AND Password = @Password;";
            return msh.ExecuteDataTable(sql, new MySqlParameter("@StaffID", staffID), new MySqlParameter("@Password", pwd));
        }

     
    }
}
