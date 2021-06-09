using SqlSugarCore_console.Models;
using SqlSugarCore_console.Orm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlSugarCore_console.Services
{
    public class HomeService : SqlSugarBase
    {
        public List<TestModel> GetTests()
        {
            return Db.Queryable<TestModel>().ToList();
        }

        public List<User> GetUsers()
        {
            return Db.Queryable<User>().ToList();
        }

        public bool Insert(User user)
        {
            return Db.Insertable<User>(user).ExecuteCommand() > 0;
        }

        public bool Delete(User user)
        {
            return Db.Deleteable<User>(x=>x.SEQ_NO==user.SEQ_NO).ExecuteCommand()>0;
        }

        public bool Update(User user)
        {
            return Db.Updateable<User>(user).WhereColumns(x=>new { x.SEQ_NO}).ExecuteCommand() > 0;
        }
    }
}
