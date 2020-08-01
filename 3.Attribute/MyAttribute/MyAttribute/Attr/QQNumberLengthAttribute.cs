using System;
using System.Collections.Generic;
using System.Text;

namespace MyAttribute.Attr
{
    [AttributeUsage(AttributeTargets.Field)]
    public class QQNumberLengthAttribute : AbstractValidateAttribute
    {
        public int _minLength { get; set; }
        public int _maxLength { get; set; }


        public override bool Validate(object value)
        {
            return value != null && value.ToString().Length >= _minLength && value.ToString().Length <= _maxLength;
        }

    }
}
