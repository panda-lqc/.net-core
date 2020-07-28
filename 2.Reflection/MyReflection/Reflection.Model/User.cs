using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection.Model
{
    public class User: BaseModel
    {
        public string Name { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }

        /// <summary>
        /// 用户状态  0.停用  1.正常    2.冻结
        /// </summary>
        public int State { get; set; }

        public int UserType { get; set; }

    }
}
