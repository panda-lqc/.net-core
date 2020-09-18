using Advanced.Factory;
using Advanced.IService;
using Advanced.Model;
using Advanced.Service;
using System;

namespace Advanced.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IServiceDal service = new MysqlServiceDal();

            Company company = service.Find<Company>(1);

            User user = new User()
            {
                Name = "张三",
                Account = "",
                Password = "",
                CompanyId = 1,
                CreateTime = DateTime.Now,
                CreatorId = 1,
                State = 1,
                UserType = 1
            };
            service.Add(user);

            Console.ReadKey();
        }
    }
}
