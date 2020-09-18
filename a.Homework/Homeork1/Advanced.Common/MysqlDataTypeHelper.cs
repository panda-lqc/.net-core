using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced.Common
{
    public class MysqlDataTypeHelper
    {
        public static MySqlDbType GetDataType(dynamic obj) 
        {
            Type type = obj.GetType();
            switch (type.Name) 
            {
                case "System.Int32":
                    return MySqlDbType.Int32;
                case "System.String":
                    return MySqlDbType.VarChar;
                case "System.DateTime":
                    return MySqlDbType.DateTime;
                default:
                    return MySqlDbType.VarChar;
            }
        }
    }
}
