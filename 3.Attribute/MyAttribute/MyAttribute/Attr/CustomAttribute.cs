using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace MyAttribute.Attr
{
    [AttributeUsage(AttributeTargets.Class,AllowMultiple = true)]
    internal class CustomAttribute : Attribute
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    [AttributeUsage(AttributeTargets.All)]
    internal class NBAttribute : Attribute
    { 
        
    }

    [AttributeUsage(AttributeTargets.Property)]
    internal class SalaryAttribute : AbstractValidateAttribute
    {
        public long _salary { get; set; }
        public SalaryAttribute(long salary)
        {
            _salary = salary;
        }

        public override bool Validate(object value) 
        {
            return value != null && long.TryParse(value.ToString(), out long lValue) && lValue > _salary;
        }
    }
}
