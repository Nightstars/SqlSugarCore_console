using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlSugarCore_console.Models
{
    [SugarTable("TestTable")]
    public class TestModel
    {
        //[SugarColumn(IsPrimaryKey =true)]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
