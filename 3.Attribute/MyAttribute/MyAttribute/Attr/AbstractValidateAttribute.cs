using System;
using System.Collections.Generic;
using System.Text;

namespace MyAttribute.Attr
{
    public abstract class AbstractValidateAttribute : Attribute
    {
        public abstract bool Validate(object value);
    }
}
