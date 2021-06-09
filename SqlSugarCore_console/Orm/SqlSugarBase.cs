using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlSugarCore_console.Orm
{
    public class SqlSugarBase
    {
        public static string ConnectionString { get; set; } 
            = "Database=Test;Server=192.168.2.114,50000;Integrated Security=False;User ID = sa; Password = Ihavenoidea@0;";
        public static SqlSugarClient Db
        {
            get => new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = ConnectionString,
                DbType = DbType.SqlServer,
                IsAutoCloseConnection = true,
                InitKeyType = InitKeyType.Attribute
            });
        }
    }
}
