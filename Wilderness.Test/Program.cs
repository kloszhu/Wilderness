using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wilderness.Linq2DB;
using System.IO;
using EnvDTE;
using System.Transactions;
using System.Data.SqlClient;
using LinqToDB;
using CommonService.LinqModel;

namespace Wilderness.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new DBResponsitory<A2>();
            var db2 = new DBResponsitory<A1>();
            //右连接
            var p = from c in db.Table
                    from d in db2.Table.RightJoin(pp => pp.Id == c.Id)
                    where d.Name.Contains("周杰伦")
                    select new { c, d};
            Console.WriteLine(p.Count());
            Console.WriteLine(p.ToString());
           
            //分页
            var o = db.Table.Skip(1).Take(20);
            Console.WriteLine(o.ToString());
            o.Set(a=>a.Name,)
            Console.ReadKey();


            //var dbs = new CommonServiceDB();

            //Console.WriteLine(count);

        }
    }
}
