using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BooksDeserialisation
{
    public enum GenreType
    {
        [XmlEnum(Name = "Computer")]
        Computer,
        [XmlEnum(Name = "Fantasy")]
        Fantasy,
        [XmlEnum(Name = "Romance")]
        Romance,
        [XmlEnum(Name = "Horror")]
        Horror,
        [XmlEnum(Name = "Science Fiction")]
        ScienceFiction
    }
}
