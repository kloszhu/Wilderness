using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB;
namespace Wilderness.Linq2DB
{
    public class DBURD<T> : DataContext where T : class, new()
    {
        public DataContext DBContext { get; set; } 
        public DBURD()
        {
            DBContext = new DataContext();
        }
        public int Insert(T entity)
        {
            return DBContext.Insert(entity);
        }
        public int Update(T entity)
        {
            return DBContext.Update(entity);
        }
        public int Delete(T entity)
        {
            return DBContext.Delete(entity);
        }
    }
}
