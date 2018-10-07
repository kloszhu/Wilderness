using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using LinqToDB;

namespace Wilderness.Linq2DB
{
    public interface IDBResponsitory<T> where T : class, new()
    {
        ITable<T> Table { get; }
        DBURD<T> URD { get; set; }

        int GetCount(Expression<Func<T, bool>> expression);
        int GetCount(IQueryable<T> queryable);
        IEnumerable<T> GetList(Expression<Func<T, bool>> expression);
        IEnumerable<T> GetList(IQueryable<T> expression);
        IEnumerable<T> GetListByPage(Expression<Func<T, bool>> expression, int currentPage, int pageSize, out int totalRecords);
        IEnumerable<T> GetListByPage(IQueryable<T> expression, int currentPage, int pageSize, out int totalRecords);
        T GetModel(Expression<Func<T, bool>> expression);
        T GetModel(IQueryable<T> expression);

        void InitDataContext();
        void InitMappingSchema();
    }
}