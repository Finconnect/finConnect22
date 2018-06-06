using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace EntityManager
{
    public class Helper
    {
        
        public string SaveXML(XmlSerializer serializer, XML_CreditTransferInstruction xml, int? id)
        {
            string filename = DateTime.Now.ToString("yyyyMMdHHmmssfff");
            
            using (TextWriter writer = new StreamWriter(@"D:\FinConnect\"+ filename + ".xml"))
            {
                serializer.Serialize(writer, xml);
            }
            return filename;
        }
    }
}
