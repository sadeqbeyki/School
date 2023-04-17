using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Create.Models
{
    public class BaseEntity
    {   
        public int Id { get; set; }
        public DateTime CreationDate { get; private set; }

        public BaseEntity()
        {
            CreationDate = DateTime.Now;
        }
    }
}
