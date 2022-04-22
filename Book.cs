using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BooksDeserialisation
{
    public class Book
    {
        [XmlAttribute("id")]
        public string id { get; set; }
        [XmlElement(ElementName = "author")]
        public string author { get; set; }
        [XmlElement(ElementName = "title")]
        public string title { get; set; }

        [XmlElement(ElementName = "genre")]
        [JsonConverter(typeof(StringEnumConverter))]
        public GenreType genre { get; set; }
        [XmlElement(ElementName = "publisher")]
        public string publisher { get; set; }
        [XmlElement(ElementName = "publish_date")]
        public string publish_date { get; set; }
        [XmlElement(ElementName = "description")]
        public string description { get; set; }
        [XmlElement(ElementName = "registration_date")]
        public string registration_date { get; set; }
    }
}
