using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using LinqToDB;
namespace Wilderness.Linq2DB
{
    public class DBResponsitory<T>: DataConnection where T :class,new()
    {
        public ITable<T> db { get { return this.GetTable<T>(); } }
        public DBResponsitory(string configuration)
            : base(configuration)
        {
        }
        public int Insert(Expression<Func<T>> setter) {
          return   db.Insert(setter);
        }
       

    }
}
