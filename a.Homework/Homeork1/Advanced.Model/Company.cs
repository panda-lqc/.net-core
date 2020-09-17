using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced.Model
{
    public class Company :BaseModel
    {
        public string Name { get; set; }
        public int CreaterId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? LastModifierId { get; set; }
        public DateTime? LastModifyTime { get; set; }
    }
}
