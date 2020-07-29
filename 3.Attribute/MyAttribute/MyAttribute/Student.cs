using MyAttribute.CustomEnum;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace MyAttribute
{
    
    //[Obsolete("过期对象，慎重使用")]
    [Serializable]
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public UserState state { get; set; }


        public void Study() 
        {
            
        }


        /// <summary>
        /// 方法的参数属性 和 返回值属性
        /// </summary>
        /// <param name="question"></param>
        [return: NB]
        public void Answer([NB] string question) 
        {
            Console.WriteLine(question);
        }
    }
}
