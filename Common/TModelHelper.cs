using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
   public static  class TModelHelper
    {

        public static TModel DataRowToModel<TModel>(this DataRow dr) {
            Type type = typeof(TModel);
            TModel md = (TModel)Activator.CreateInstance(type);
            foreach (var prop in type.GetProperties())
            {
                if (dr.Table.Columns.Contains(prop.Name) && dr[prop.Name] != DBNull.Value)
                {
                    prop.SetValue(md, dr[prop.Name]);
                }
            }
            return md;
        }
    }
}
