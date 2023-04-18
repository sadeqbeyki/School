using School.TopTeacher.Models;
using School.TopTeacher.Models.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Create.Models.Address
{
    public class State : BaseEntity
    {
        public string Name { get; set; }
        public List<County> Counties { get; set; }
    }
}
