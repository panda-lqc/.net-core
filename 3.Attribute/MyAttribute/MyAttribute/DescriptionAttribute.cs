using System;
using System.Collections.Generic;
using System.Text;

namespace MyAttribute
{
    internal class DescriptionAttribute : Attribute
    {
        public string Dscription { get; private set; }

        public DescriptionAttribute(string description)
        {
            this.Dscription = description;
        }

    }
}
