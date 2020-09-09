using System;
using System.Collections.Generic;
using System.Text;

namespace MyOOP.Model
{
    public class IPhone : Phone,IBrowse,IMusic//,Office
    {

        public override void System()
        {
            Console.WriteLine("IOS");
        }

        public void Browse()
        {
            Console.WriteLine("Safari");
        }

        void IMusic.Music()
        {
            Console.WriteLine("Apple Music");
        }
    }
}
