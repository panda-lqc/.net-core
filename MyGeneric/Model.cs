using System;
using System.Collections.Generic;
using System.Text;

namespace MyGeneric
{
    public interface ISports
    {
        void PingPang();
    }

    public interface IWork
    {
        void Work();
    }

    public class People 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public void Hi() 
        { }
    }

    public class Chinese : People, ISports, IWork
    {
        public void Tradition()
        {
            Console.WriteLine("八荣八耻牢记心中！");
        }
        public void SayHi()
        {
            Console.WriteLine("吃了吗？");
        }
        public void PingPang()
        {
            Console.WriteLine("打乒乓！");
        }

        public void Work()
        {
            Console.WriteLine("写代码！");
        }
    }

    public class Henan : Chinese 
    {
        public string HuangHe { get; set; }

        public void Huimian() 
        {
            Console.WriteLine("吃烩面！");
        }
    }

    public class Japanese : ISports
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void PingPang()
        {
            Console.WriteLine("打乒乓！");
        }
    }
}
