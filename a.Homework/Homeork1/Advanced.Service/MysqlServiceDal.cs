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
    public class MysqlServiceDal : IServiceDal
    {
        public string connString = "";

        public bool Add<T>(T t) where T : BaseModel
        {
            Type type = typeof(T);
            object obj = Activator.CreateInstance(type);

            var propName = string.Join(',', type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
                .Where(p => !p.Name.Equals("Id")).Select(t => $"[{t.Name}]"));
            
            var propValue = string.Join(',', type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
                .Where(p => !p.Name.Equals("Id")).Select(a => $"@{a.Name}"));

            string sql = $"INSERT INTO [{type.Name}]({propName}) VALUES({propValue})";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                List<MySqlParameter> para = type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
                .Where(p => !p.Name.Equals("Id")).Select(item => new MySqlParameter()
                {
                    ParameterName = $"{item.Name}",
                    Value = item.GetValue(t)
                }).ToList();

                cmd.Parameters.AddRange(para.ToArray());

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete<T>(T t) where T : BaseModel
        {
            Type type = typeof(T);

            //var propName = string.Join(',', type.GetProperties().Select(a => $"[{a.Name}]"));
            string sql = $"DELETE {type.Name} WHERE Id = @Id";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                cmd.Parameters.Add(new MySqlParameter("@Id", t.Id));

                return cmd.ExecuteNonQuery() > 0;
            }
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
                        item.SetValue(obj, reader[item.Name] is DBNull ? null : reader[item.Name]);
                    }
                }
                else
                {
                    return null;
                }
            }

            return (T)obj;
        }

        public List<T> FindAll<T>() where T : BaseModel
        {
            List<T> list = new List<T>();


            Type type = typeof(T);
            
            var propName = string.Join(',', type.GetProperties().Select(a => $"[{a.Name}]"));
            string sql = $"SELECT {propName} FROM {type.Name}";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    object obj = Activator.CreateInstance(type);

                    foreach (PropertyInfo item in type.GetProperties())
                    {
                        item.SetValue(obj, reader[item.Name] is DBNull ? null : reader[item.Name]);
                    }

                    list.Add((T)obj);
                }
            }
            return list;
        }

        public bool Update<T>(T t) where T : BaseModel
        {
            Type type = typeof(T);

            string updString = string.Join(",", type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
                .Where(p => !p.Name.Equals("Id")).Select(p => $"{p.Name}=@{p.Name}"));
            string sql = $"UPDATE {type.Name} SET {updString} WHERE Id = @Id";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                MySqlCommand cmd = new MySqlCommand(sql,conn);
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                List<MySqlParameter> para = type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly)
                .Select(item => new MySqlParameter()
                {
                    ParameterName = $"{item.Name}",
                    Value = item.GetValue(t)
                }).ToList();

                cmd.Parameters.AddRange(para.ToArray());

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
