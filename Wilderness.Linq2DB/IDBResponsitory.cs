using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using LinqToDB;
using LinqToDB.Data;

namespace Wilderness.Linq2DB
{
    public interface IDBResponsitory<T> where T : class, new()
    {
        ITable<T> Table { get; }


        int GetCount(Expression<Func<T, bool>> expression);
        IEnumerable<T> GetList(Expression<Func<T, bool>> expression);
        IEnumerable<T> GetListByPage(Expression<Func<T, bool>> expression, int currentPage, int pageSize, out int totalRecords);
        T GetModel(Expression<Func<T, bool>> expression);

        void InitDataContext();
        void InitMappingSchema();

        DataConnectionTransaction BeginTransaction();
        DataConnectionTransaction BeginTransaction(IsolationLevel isolationLevel);
        void Close();
        void CommitTransaction();
        void RollbackTransaction();
    }
}