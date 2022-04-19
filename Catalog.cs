﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BooksDeserialisation
{
    //[Serializable, XmlRoot("catalog")]
    [XmlRoot(ElementName = "catalog", Namespace = "http://library.by/catalog")]
    public class Catalog
    {
        [XmlElement(ElementName = "book")]
        public List<Book> books { get; set; }

        /*[XmlAttribute("xmlns")]
        public string Xmlns { get; set; }*/

        [XmlAttribute("date")]
        public string date { get; set; }
    }
    
}
