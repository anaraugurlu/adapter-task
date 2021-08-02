using adapter_task.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter_task.Extention
{
    class XmlAdapter : IAdapter
    {
        XmlDb _db;

        public XmlAdapter(XmlDb db)
        {
            _db = db;
        }



      

        public void Serialize(User user)
        {
            _db.SerializeXml(user);
        }

        User IAdapter.Deserialize()
        {
           return  _db.DeserializeXml();
        }
    }
}
