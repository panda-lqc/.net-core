using System;
using System.Collections.Generic;
using System.Text;

namespace MyGeneric
{
    public class GenericTest
    {
        /// <summary>
        /// 泛型方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tParameter"></param>
        public static void Show<T>(T tParameter)
        {
            Console.WriteLine($"This is {typeof(GenericTest).Name},parameter={tParameter},type={tParameter.GetType().Name}");
        }

        /// <summary>
        /// 泛型类
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class GenericClass<T>
        {
        }

        /// <summary>
        /// 泛型接口
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public interface GenericInterface<T>
        {
        }

        /// <summary>
        /// 泛型类的继承
        /// </summary>
        /// <typeparam name="S"></typeparam>
        /// <typeparam name="T"></typeparam>
        public class ChildClass<S, T> : GenericClass<S>, GenericInterface<T>
        {
        }

        /// <summary>
        /// 泛型委托
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public delegate void Do<T>();
    }
}
