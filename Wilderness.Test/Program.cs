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
            var p = from c in db.Table
                    from d in db2.Table.RightJoin(pp => pp.Id == c.Id)
                    where d.Name.LastIndexOf("周杰伦")>0
                    select c;
            var count=db.GetCount(p);
            Console.WriteLine(p.ToString());
            var dbs = new CommonServiceDB();

            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
