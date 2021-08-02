using adapter_task.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace adapter_task.Extention
{
   public class XmlDb
    {
        public void SerializeXml(User user)
        {

            var xml = new XmlSerializer(typeof(User));
            using (var fs = new FileStream("user.xml", FileMode.OpenOrCreate))
            {
                xml.Serialize(fs, user);
            }
        }

        public User DeserializeXml()
        {
            User user = null;
            var xml = new XmlSerializer(typeof(User));
            using (var fs = new FileStream("Person.xml", FileMode.OpenOrCreate))
            {
                user = xml.Deserialize(fs) as User;
            }
            return user;
        }

    }
}
