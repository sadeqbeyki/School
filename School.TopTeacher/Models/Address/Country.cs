
using School.Create.Models;
using School.Create.Models.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.TopTeacher.Models.Address
{
    public class Country : BaseEntity
    {
        public string Name { get; set; }
        public List<State> States { get; set; }
    }
}
