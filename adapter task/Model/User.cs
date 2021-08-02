using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter_task.Model
{
 public   class User:Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string  Email { get; set; }
    }
}
