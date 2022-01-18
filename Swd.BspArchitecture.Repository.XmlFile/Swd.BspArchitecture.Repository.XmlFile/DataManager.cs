using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace Swd.BspArchitecture.Repository.XmlFile
{
    public class DataManager
    {
        public string ReadData()
        {
            string returnValue = string.Empty;
            string filePath = Properties.Settings.Default.PathToXmlFile;
            if(File.Exists(filePath))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(filePath);
                returnValue = doc.SelectSingleNode("Message/Text").InnerText;
            }
            return returnValue;
        }


    }
}
