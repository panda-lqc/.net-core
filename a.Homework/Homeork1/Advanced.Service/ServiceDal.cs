using Advanced.IService;
using Advanced.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Reflection;

namespace Advanced.Service
{
    public class ServiceDal : IServiceDal
    {
        public string connString = "";

        public bool Add<T>(T t) where T : BaseModel
        {
            Type type = typeof(T);

            object obj = Activator.CreateInstance(type);

            var propName = string.Join(',', type.GetProperties().Select(a => $"[{a.Name}]"));
            string sql = $"INSERT INTO {{type.Name}}({propName}) VALUES()";

            return true;
        }

        public bool Delete<T>(T t) where T : BaseModel
        {
            throw new NotImplementedException();
        }

        public T Find<T>(int Id) where T : BaseModel
        {
            Type type = typeof(T);

            object obj = Activator.CreateInstance(type);

            var propName = string.Join(',', type.GetProperties().Select(a => $"[{a.Name}]"));
            string sql = $"SELECT {propName} FROM {type.Name} WHERE Id = @Id";

            using (MySqlConnection conn = new MySqlConnection(connString)) 
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                cmd.Parameters.Add(new MySqlParameter("@Id", Id));

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    foreach (PropertyInfo item in type.GetProperties())
                    {
                        item.SetValue(obj,reader[item.Name]);
                    }
                }
            }

            return (T)obj;
        }

        public List<T> FindAll<T>() where T : BaseModel
        {
            throw new NotImplementedException();
        }

        public bool Update<T>(T t) where T : BaseModel
        {
            throw new NotImplementedException();
        }
    }
}
