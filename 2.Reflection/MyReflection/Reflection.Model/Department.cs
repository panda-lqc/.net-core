using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection.Model
{
    public class Department : BaseModel
    {
        public string Name { get; set; }
        public DateTime CreateTime { get; set; }
        public int CreatorId { get; set; }
        public int? lastModifierId { get; set; }
        public DateTime? lastModifyTime { get; set; }
    }
}
