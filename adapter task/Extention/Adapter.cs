using adapter_task.Extention;
using adapter_task.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adapter_task
{
    class Adapter
    {

    private readonly IAdapter _adapter;
    public Adapter(IAdapter adapter)
    {
        _adapter = adapter;
    }
    public void Serialize(User user)
    {
        _adapter.Serialize(user);
    }
    public User Deserialize()
    {
        return _adapter.Deserialize ();
    }
    }
    //interface IAdapter
    //    {
    //    void Serialize();
    //    void Deserialize();
    //    }
 //class XmlDb
 //       {
 //        public void SerializeXml()
 //       {

           
 //           }
        
 //       public void DeserializeXml()
 //       {

 //       }
           
 //       }
 //   class JsonDb
 //   {
 //       public void SerializeJson()
 //       {


 //       }

 //       public void DeserializeJson()
 //       {

 //         List<  User>Users  = null;


 //           //var serializer = new JsonSerializer();





 //           using (StreamReader sr = new StreamReader("car.json"))


 //           {


 //               //using (var jr = new JsonTextReader(sr))


 //               //{


 //               //    Users = serializer.Deserialize<User[]>(jr);


 //               //}


 //               foreach (var item in Users)


 //               {


 //                   Console.WriteLine(item);


 //               }


 //           }

 //       }

 //   }
    //class XmlAdapter : IAdapter
    //    {
    //        XmlDb _db;

    //        public XmlAdapter(XmlDb db)
    //        {
    //            _db = db;
    //        }

        

    //    public void Deserialize()
    //    {
    //        throw new NotImplementedException();
    //    }

        

    //    public void Serialize()
    //    {
    //        throw new NotImplementedException();
    //    }

      
    //class JsonAdapter : IAdapter
    //{
    //    JsonDb _db;

    //    public JsonAdapter(JsonDb db)
    //    {
    //        _db = db;
    //    }

    //    public void Serialize()
    //    {
            
    //    }

       

    //        public void Deserialize()
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }

}

