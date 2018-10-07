using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using LinqToDB;
using LinqToDB.SqlQuery;
using System.Data;

namespace Wilderness.Linq2DB
{
    public class DBResponsitory<T> : DataConnection, IDBResponsitory<T> where T : class, new()
    {
        public DBURD<T> URD { get; set; }
        public ITable<T> Table { get { return this.GetTable<T>(); } }
        public DBResponsitory()
        {
            InitDataContext();
            InitMappingSchema();
        }

        public DBResponsitory(string configuration)
            : base(configuration)
        {
            InitDataContext();
            InitMappingSchema();
        }
        public void InitMappingSchema()
        {
        }
        public void InitDataContext() {
            URD = new DBURD<T>();
        }
      
        public int GetCount(Expression<Func<T, bool>> expression)
        {
            return Table.Count(expression);
        }
        public int GetCount(IQueryable<T> queryable) {
            return queryable.Count();
        }
        public T GetModel(Expression<Func<T, bool>> expression)
        {
            return Table.FirstOrDefault(expression);
        }
        public T GetModel(IQueryable<T> expression)
        {
            return expression.FirstOrDefault();
        }
        public IEnumerable<T> GetList(Expression<Func<T, bool>> expression)
        {
            return Table.Where(expression);
        }
        public IEnumerable<T> GetList(IQueryable<T> expression)
        {
            return expression;
        }

        public IEnumerable<T> GetListByPage(Expression<Func<T, bool>> expression, int currentPage, int pageSize, out int totalRecords)
        {
            totalRecords = this.GetCount(expression);
            return Table.Where(expression).Skip((currentPage - 1) * pageSize).Take(pageSize);
        }
        public IEnumerable<T> GetListByPage(IQueryable<T> expression, int currentPage, int pageSize, out int totalRecords)
        {
            totalRecords = this.GetCount(expression);
            return expression.Skip((currentPage - 1) * pageSize).Take(pageSize);
        }
    }
}
