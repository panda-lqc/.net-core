using System;
using System.Collections.Generic;
using System.Text;

namespace MyGeneric
{
    public class GenericConstraint
    {
        public static void ShowObject(object oParameter)
        {
            People people = (People)oParameter;
            Console.WriteLine(people.Id);

            Console.WriteLine($"This is {typeof(CommonMethod).Name},parameter={oParameter},type={oParameter.GetType().Name}");
        }

        public static void Show<T>(T tParameter) where T : People
        {
            Console.WriteLine($"This is {typeof(CommonMethod).Name},parameter={tParameter},type={tParameter.GetType().Name}");
        }


    }
}
