using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MyOOP.Model
{
    public abstract class Phone
    {
        public string PhoneNumber { get; set; }

        public abstract void System();

        public void Open() 
        {
            Console.WriteLine("开机");
        }

        public void Call() 
        {
            Console.WriteLine("");
        }

        public void Message() 
        {
            Console.WriteLine("");
        }
    }
}
