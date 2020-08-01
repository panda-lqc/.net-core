using System;
using System.Collections.Generic;
using System.Text;

namespace MyAttribute.Attr
{
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
