using MyAttribute.Attr;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyAttribute.CustomEnum
{
    public enum UserState
    {
        [Description("正常")]
        Normal = 0,

        [Description("冻结")]
        Forzen = 1,

        [Description("删除")]
        Delete = 2
    }
}
