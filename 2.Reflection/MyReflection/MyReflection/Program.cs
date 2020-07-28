using Reflection.Interface;
using System;

namespace MyReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IDBHelper helper = SimpleFactory.GetMySqlHelper();
            helper.Query();

            IDBHelper currentDbHelper = SimpleFactory.GetCurrentDBHelper();
            currentDbHelper.Query();
        }
    }
}
