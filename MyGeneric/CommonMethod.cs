using System;
using System.Collections.Generic;
using System.Text;

namespace MyGeneric
{
    public class CommonMethod
    {
        /// <summary>
        /// 输出int
        /// </summary>
        /// <param name="iParameter"></param>
        public static void ShowInt(int iParameter)
        {
            Console.WriteLine($"This is {typeof(CommonMethod).Name},parameter={iParameter.GetType().Name},type={iParameter}");
        }

        /// <summary>
        /// 输出string
        /// </summary>
        /// <param name="sParameter"></param>
        public static void ShowString(string sParameter) 
        {
            Console.WriteLine($"This is {typeof(CommonMethod).Name},parameter={sParameter.GetType().Name},type={sParameter}");
        }

        /// <summary>
        /// 输出DataTime
        /// </summary>
        /// <param name="dtParameter"></param>
        public static void ShowDateTime(DateTime dtParameter) 
        {
            Console.WriteLine($"This is {typeof(CommonMethod).Name},parameter={dtParameter.GetType().Name},type={dtParameter}");
        }

        /// <summary>
        /// 输出Object
        /// </summary>
        /// <param name="oParameter"></param>
        public static void ShowObject(object oParameter) 
        {
            Console.WriteLine($"This is {typeof(CommonMethod).Name},parameter={oParameter.GetType().Name},type={oParameter}");
        }

        /// <summary>
        /// 输出泛型变量
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tParameter"></param>
        public static void Show<T>(T tParameter) 
        {
            Console.WriteLine($"This is {typeof(CommonMethod).Name},parameter={tParameter.GetType().Name},type={tParameter}");
        }
    }
}
