using System;
using System.Collections.Generic;
using System.Text;

namespace MyDelegate
{
    public class MyDeleg
    {

        public delegate void NoReturnNonPara();
        public delegate void NoReturnWithPara(int x);
        public delegate int WithReturnNoPara();
        public delegate int WithReturnWithPara(int x, int y);


    }
}
