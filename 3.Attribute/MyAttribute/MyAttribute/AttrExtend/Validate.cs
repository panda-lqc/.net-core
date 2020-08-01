using MyAttribute.Attr;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MyAttribute.AttrExtend
{
    public static class Validate
    {
        public static bool Validating(this Student student) 
        {
            Type type = student.GetType();

            foreach (var item in type.GetProperties())
            {
                if (item.IsDefined(typeof(AbstractValidateAttribute),true))
                {
                    object value = item.GetValue(student);

                    foreach (AbstractValidateAttribute attr in item.GetCustomAttributes(typeof(AbstractValidateAttribute), true))
                    {
                        if (!attr.Validate(value))
                        {
                            return false;
                        }
                    }
                }
            }

            foreach (var item in type.GetFields())
            {
                if (item.IsDefined(typeof(AbstractValidateAttribute), true))
                {
                    object value = item.GetValue(student);

                    foreach (AbstractValidateAttribute attr in item.GetCustomAttributes(typeof(AbstractValidateAttribute), true))
                    {
                        if (!attr.Validate(value))
                        {
                            return false;
                        }
                    }
                }
            }

            return false;
        }
    }
}
