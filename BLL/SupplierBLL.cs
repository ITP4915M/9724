using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Models;

namespace BLL
{
    public class SupplierBLL
    {
        SupplierDAL supplierDAL = new SupplierDAL();
        public List<Supplier> GetAllSupplier()
        {
            return supplierDAL.SelectAllSupplier();
        }
    }
}

