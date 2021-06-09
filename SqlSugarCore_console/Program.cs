using Newtonsoft.Json;
using SqlSugarCore_console.Services;
using System;

namespace SqlSugarCore_console
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeService homeService = new HomeService();
            //var rs = homeService.GetTests();
            //Console.WriteLine(JsonConvert.SerializeObject(rs));
            //Console.WriteLine();

            //var success=homeService.Insert(new Models.User
            //{
            //    SEQ_NO = Guid.NewGuid().ToString().Replace("-", ""),
            //    NAME="test",
            //    PHONE="19987654321",
            //    EMAIL="test@test.com",
            //    ADDRESS="test,test,test"
            //});
            //Console.WriteLine(success);
            //Console.WriteLine();

            var result = homeService.GetUsers();
            Console.WriteLine(JsonConvert.SerializeObject(result));
            Console.WriteLine();

            //var deleteRs = homeService.Delete(result[0]);
            //Console.WriteLine(deleteRs);
            //Console.WriteLine();

            var rs = result[0];
            rs.NAME = "alice";
            rs.PHONE = "19987654321";
            rs.EMAIL = "ha@ha.com";
            rs.ADDRESS = "not on earth";
            var deleteRs = homeService.Update(result[0]);
            Console.WriteLine(deleteRs);
            Console.WriteLine();

            var result1 = homeService.GetUsers();
            Console.WriteLine(JsonConvert.SerializeObject(result1));
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
