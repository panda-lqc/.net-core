using Reflection.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection;
using System.Text;

namespace MyReflection
{
    public class SimpleFactory
    {
        private static readonly string dbHelperConfig = ConfigurationManager.AppSettings["DBHelperConfig"];
        private static readonly string dllName = dbHelperConfig.Split(',')[1];
        private static readonly string typeName = dbHelperConfig.Split(',')[0];


        public static IDBHelper GetSqlServerHelper() 
        {
            Assembly assembly = Assembly.Load("Reflection.DB.SqlServer");
            Type type = assembly.GetType("Reflection.DB.SqlServer.SqlServerHelper");
            var dbHelper = Activator.CreateInstance(type);
            return dbHelper as IDBHelper;
        }

        public static IDBHelper GetMySqlHelper() 
        {
            Assembly assembly = Assembly.Load("Reflection.DB.Mysql");
            Type type = assembly.GetType("Reflection.DB.Mysql.MySqlHelper");
            var dbHelper = Activator.CreateInstance(type);
            return dbHelper as IDBHelper;
        }

        public static IDBHelper GetCurrentDBHelper() 
        {
            Assembly assembly = Assembly.Load(dllName);
            Type type = assembly.GetType(typeName);
            var dbHelper = Activator.CreateInstance(type);
            return dbHelper as IDBHelper;
        }
    }
}
