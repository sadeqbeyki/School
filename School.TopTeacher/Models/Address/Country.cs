using Amozegar.Create.Models;
using Amozegar.Create.Models.Address;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.TopTeacher.Models.Address
{
    internal class Country : BaseEntity
    {
        public string Name { get; set; }
        public List<State> States { get; set; }
    }
}
