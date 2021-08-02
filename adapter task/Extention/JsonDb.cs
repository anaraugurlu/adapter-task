using adapter_task.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter_task.Extention
{
    class JsonDb

    {
        public void SerializeJson(User user)
        {
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter("user.json"))
            {
                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, user);
                }
            }
        }
        public User DeserializeJson()
        {
            User user = null;
            var serializer = new JsonSerializer();

            using (StreamReader sr = new StreamReader("user.json"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    user = serializer.Deserialize<User>(jr);
                }
            }

            return user;
        }
      

    }
}
