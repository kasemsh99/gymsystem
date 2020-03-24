using System;
using System.Linq;
using System.IO;
using System.Xml.Serialization;


namespace WpfApp1
{
    class Database
    {
        public static void savedata(object obj , string filename)
         {
            XmlSerializer sr = new XmlSerializer(obj.GetType());
            TextWriter writer = new StreamWriter(filename);
            sr.Serialize(writer, obj);
            writer.Close();
        }
    }
}
