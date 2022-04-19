﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace BooksDeserialisation
{
    internal class Program
    {
        public static void DeSerialiseData()
        {

            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Users\Prakarsh_Srivastava\OneDrive - EPAM\BooksDeserialisation\books.xml");
            Catalog obj;
            using (TextReader textReader = new StringReader(doc.OuterXml))
            {
                using (XmlTextReader reader = new XmlTextReader(textReader))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Catalog));
                    obj = (Catalog)serializer.Deserialize(reader);

                }
            }
            string json = JsonConvert.SerializeObject(obj);
            File.WriteAllText(@"C:\Users\Prakarsh_Srivastava\OneDrive - EPAM\BooksDeserialisation\Jbooks.json", json);

        }
        static void Main(string[] args)
        {
            DeSerialiseData();
            Console.WriteLine();
        }
    }
}