using Advanced.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced.IService
{
    public interface IServiceDal
    {
        bool Add<T>(T t) where T : BaseModel;
        bool Delete<T>(T t) where T : BaseModel;
        bool Update<T>(T t) where T : BaseModel;
        T Find<T>(int Id) where T : BaseModel;
        List<T> FindAll<T>() where T : BaseModel;
    }
}
