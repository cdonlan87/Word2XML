using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Word2XML_2
{
    [XmlType("Field")]
    public class FieldXML
    {
        [XmlAttribute("FieldID")]
        public string FieldID;
        [XmlAttribute("FieldValue")]
        public string FieldValue;
        public FieldXML() { }
        public FieldXML(string a,string b)
        {
            this.FieldID = a;
            this.FieldValue = b;
        }
    }
}
