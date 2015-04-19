using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Word2XML_2
{
    public static class FieldSerializerXML
    {
        public static void SerializeObject(this List<FieldXML> fields, string file)
        {
            var serializer = new XmlSerializer(typeof(List<FieldXML>));
            using (var stream = File.OpenWrite(file))
            {
                serializer.Serialize(stream, fields);
            }
        }
    }
    public static class FieldSerializerXML2
    {
        public static void SerializeObject(this List<MyTupleXML<string,string>>fields, string file)
        {
            var serializer = new XmlSerializer(typeof(List<MyTupleXML<string, string>>));
            using (var stream = File.OpenWrite(file))
            {
                serializer.Serialize(stream, fields);
            }
        }
    }
}
