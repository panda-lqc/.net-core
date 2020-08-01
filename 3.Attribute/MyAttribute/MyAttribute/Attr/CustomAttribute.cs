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

    
}
