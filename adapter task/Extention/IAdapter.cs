using adapter_task.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter_task.Extention
{
    interface IAdapter
    {
        void Serialize(User user);
        User Deserialize();
    }
}
