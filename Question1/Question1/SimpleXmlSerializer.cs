using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Question1
{
    public class SimpleXmlSerializer
    {
        public void Serialize(object object_serialized, string path_XML)
        {
            var serializer = new XmlSerializer(object_serialized.GetType());
            using (var writer = XmlWriter.Create(path_XML))
            {
                serializer.Serialize(writer, object_serialized);
            }
        }

    }
}
