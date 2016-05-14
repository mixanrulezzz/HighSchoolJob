using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace XMLSerializator
{
    public static class XMLSer<T> where T : class
    {
        private static XmlSerializer xmls = new XmlSerializer(typeof(T));
        public static bool Error = false;
        public static void Serializator(string file, T inf)
        {
            StreamWriter sw = new StreamWriter(file, true);
            xmls.Serialize(sw, inf);
            sw.Close();
        }

        public static T Deserializator(string file)
        {
            T inf = null;
            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    inf = xmls.Deserialize(sr) as T;
                }
            }
            catch (InvalidOperationException)
            { Error = true; }
            catch (System.IO.FileNotFoundException)
            { Error = true; }
            return inf;
        }
    }
}
