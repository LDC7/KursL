using System.IO;
using System.Xml.Serialization;

namespace KursL
{
    public abstract class XmlSer
    {
        public static T Deserialize<T>(StreamReader stream)
        {
            T obj;
            var Serializer = new XmlSerializer(typeof(T));
            obj = (T)Serializer.Deserialize(stream);

            return obj;
        }
        
        public static string Serialize<T>(T obj)
        {
            var Serializer = new XmlSerializer(typeof(T));
            MemoryStream stream = new MemoryStream();
            Serializer.Serialize(stream, obj);

            stream.Position = 0;
            string str = (new StreamReader(stream)).ReadToEnd();

            return str;
        }
    }
}
