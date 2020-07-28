using Reflection.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection.DB.Mysql
{
    public class MySqlHelper : IDBHelper
    {
        public MySqlHelper() 
        {
            Console.WriteLine("{0}，被构造。", this.GetType().Name);
        }

        public void Query() 
        {
            Console.WriteLine("{0}的Query被调用。", this.GetType().Name);
        }
    }
}
