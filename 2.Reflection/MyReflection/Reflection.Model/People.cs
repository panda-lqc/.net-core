using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection.Model
{
    public class People
    {
        public People() 
        {
            Console.WriteLine("{0}，被构造。", this.GetType().Name);
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
