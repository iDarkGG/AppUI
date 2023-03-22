
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AppDependencies
{
    public class FileParser
    {

        
        public void CreateFile()
        {
            XmlDocument documento = new XmlDocument();

            XmlElement raiz = documento.CreateElement("DataBase");
            documento.AppendChild(raiz);

            CurrentDataBuffer a = new CurrentDataBuffer();

            UserDataScheme var = a.dataReader();
            

        }

    }
}
