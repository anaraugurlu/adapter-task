using adapter_task.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter_task.Extention
{
    class JsonAdapter : IAdapter
    {
        JsonDb _db;

        public JsonAdapter(JsonDb db)
        {
            _db = db;
        }

       



        public void Deserialize()
        {
            _db.DeserializeJson();
        }

        public void Serialize(User user)
        {
            _db.SerializeJson(user);
        }

        User IAdapter.Deserialize()
        {
            throw new NotImplementedException();
        }
    }
}
