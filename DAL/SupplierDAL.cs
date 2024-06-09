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
    public class SupplierDAL
    {
        DAL.MysqlHelper msh = new DAL.MysqlHelper(ConfigurationManager.ConnectionStrings["connstr"].ToString());

        public List<Supplier> SelectAllSupplier()
        {
            List<Supplier> sp = new List<Supplier>();
            DataTable dt = msh.ExecuteDataTable(@" SELECT  * FROM supplier;");
            foreach (DataRow dr in dt.Rows)
            {
                sp.Add(ToModel(dr));
            }
            return sp;
        }

        private Supplier ToModel(DataRow dr)
        {
            Supplier st = new Supplier();

            st.SupplierID = dr["SupplierID"].ToString();
            st.SupplierName = dr["SupplierName"].ToString();
            st.SupplierAddress = dr["SupplierAddress"].ToString();
            st.PhoneNo = (long)dr["PhoneNo"];
            st.Website = dr["Website"].ToString();
            st.Payment = dr["Payment"].ToString();
            st.Email = dr["Email"].ToString();

            return st;
        }

        public void UpdateSupplier(Supplier supplier)
        {
            string sql = "Update Supplier Set " + "SupplierID = @SupplierID, SupplierName = @SupplierName, SupplierAddress = @SupplierAddress" +
                "PhoneNo = @PhoneNo, Website = @Website, Payment = @Payment, Email = @Email ";

            int row = msh.ExecuteNonQuery(sql,

                new MySqlParameter("@SupplierID", supplier.SupplierID),
                new MySqlParameter("@SupplierName", supplier.SupplierName),
                new MySqlParameter("@SupplierAddress", supplier.SupplierAddress),
                new MySqlParameter("@PhoneNo", supplier.PhoneNo),
                new MySqlParameter("@Website", supplier.Website),
                new MySqlParameter("@Payment", supplier.Payment),
                new MySqlParameter("@Email", supplier.Email)
            );
        }

        public int InsertSupplier(Supplier supplier)
        {
            string sql = "INSERT INTO Supplier VALUES(@Supplier,@SupplierName,@SupplierAddress, " +
                "@PhoneNo,@Website,@Payment,@Email)";
            int row = msh.ExecuteNonQuery(sql,

            new MySqlParameter("@SupplierID", supplier.SupplierID),
            new MySqlParameter("@SupplierName", supplier.SupplierName),
            new MySqlParameter("@SupplierAddress", supplier.SupplierAddress),
            new MySqlParameter("@PhoneNo", supplier.PhoneNo),
            new MySqlParameter("@Website", supplier.Website),
            new MySqlParameter("@Payment", supplier.Payment),
            new MySqlParameter("@Email", supplier.Email)
            );
            return 1;
        }

        public Supplier GetSupplierByID(string supplierID)
        {
            Supplier supplier = null;
            string sql = "SELECT * FROM Supplier WHERE SupplierID = @SupplierID";
            DataTable dt = msh.ExecuteDataTable(sql, new MySqlParameter("@SupplierID", supplierID));

            if (dt.Rows.Count > 0)
            {
                supplier = ToModel(dt.Rows[0]);
            }

            return supplier;
        }

        public int DeleteSupplier(string supplierID)
        {
            string sql = "DELETE FROM Supplier WHERE SupplierID = @SupplierID";
            int row = msh.ExecuteNonQuery(sql, new MySqlParameter("@SupplierID", supplierID));
            return row;
        }

        public List<Supplier> SearchSuppliers(string searchTerm)
        {
            List<Supplier> suppliers = new List<Supplier>();
            string sql = "SELECT * FROM Supplier " +
                         "WHERE SupplierName LIKE @SearchTerm " +
                         "OR SupplierAddress LIKE @SearchTerm";
            DataTable dt = msh.ExecuteDataTable(sql, new MySqlParameter("@SearchTerm", "%" + searchTerm + "%"));

            foreach (DataRow dr in dt.Rows)
            {
                Supplier supplier = ToModel(dr);
                suppliers.Add(supplier);
            }

            return suppliers;
        }


    }

}
