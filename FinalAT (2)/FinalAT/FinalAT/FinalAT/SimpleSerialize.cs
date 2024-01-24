using System;
using System.Collections.Generic;

using System.IO;
using System.Text;
using System.Xml;

namespace FinalAT
{
    class SimpleSerialize
    {
        public void Serialize(Object o, string pathXML) {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(o.GetType());
            Stream fs = new FileStream(pathXML, FileMode.Create);
            XmlWriter writer = new XmlTextWriter(fs, Encoding.Unicode);
            // Serialize using the XmlTextWriter.
            serializer.Serialize(writer, o);
        }

    }
}
