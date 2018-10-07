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
        public IEnumerable<T> GetList(Expression<Func<T, bool>> expression)
        {
            return Table.Where(expression);
        }

        public IEnumerable<T> GetListByPage(Expression<Func<T, bool>> expression, int currentPage, int pageSize, out int totalRecords)
        {
            totalRecords = Table.Count();
            return Table.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
        }

        public override void Close()
        {
            base.Close();
        }

        public override DataConnectionTransaction BeginTransaction()
        {
            return base.BeginTransaction();
        }

        public override DataConnectionTransaction BeginTransaction(IsolationLevel isolationLevel)
        {
            return base.BeginTransaction(isolationLevel);
        }

        public override void CommitTransaction()
        {
            base.CommitTransaction();
        }

        public override void RollbackTransaction()
        {
            base.RollbackTransaction();
        }

        protected override SqlStatement ProcessQuery(SqlStatement statement)
        {
            return base.ProcessQuery(statement);
        }



    }
}
