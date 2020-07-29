using System;
using System.Collections.Generic;
using System.Text;

namespace MyAttribute
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
