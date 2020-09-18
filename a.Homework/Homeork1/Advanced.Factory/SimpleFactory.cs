using Advanced.IService;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection;
using System.Text;

namespace Advanced.Factory
{
    public class SimpleFactory
    {
        private static string factoryConfig = ConfigurationManager.AppSettings["factoryConfig"];
        private static string dllName = factoryConfig.Split(",")[1];
        private static string typeName = factoryConfig.Split(",")[0];

        public static IServiceDal CreateService() 
        {
            Assembly assembly = Assembly.Load(dllName);
            Type type = assembly.GetType(typeName);
            return (IServiceDal)Activator.CreateInstance(type);
        }
    }
}
