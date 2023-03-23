using System.Xml;
using AppDependencies;
public class uwu
{
    static void Main(string[] args)
    {

        void CrearBasedeDatos(string Name)
        {
            XmlDocument DataBase = new XmlDocument();
            XmlNode root = DataBase.CreateElement("DATOS");
            DataBase.AppendChild(root);


            XmlElement UserName = DataBase.CreateElement("Default_UserName");
            UserName.SetAttribute("value", "Admin");

            XmlElement Password = DataBase.CreateElement("Default_Password");
            Password.InnerText = "Admin123";

            XmlElement Email = DataBase.CreateElement("Default_Email");
            Email.InnerText = "Admin@gmail.com";

            UserName.AppendChild(Password);
            UserName.AppendChild(Email);

            root.AppendChild(UserName);

            DataBase.Save("Prueba2.xml");
            DataBase.Save(Name + ".xml");

        }

        void Search(string elementName, string attributeName, string attributeValue)
        {
            XmlDocument DataBase = new XmlDocument();
            DataBase.Load("Prueba2.xml");

            XmlNodeList nodes = DataBase.GetElementsByTagName(elementName);
            foreach (XmlNode node in nodes)
            {
                if (node.Attributes[attributeName] != null && node.Attributes[attributeName].Value == attributeValue)
                {
                    Console.WriteLine("Elemento Encontrado");
                    Console.WriteLine(node.OuterXml);
                    return;
                }
                else
                {
                    XmlNode childNode = node.FirstChild;

                    while (childNode != null)
                    {
                        if (childNode.Attributes != null && childNode.Attributes[attributeName] != null && childNode.Attributes[attributeName].Value == attributeValue)
                        {
                            Console.WriteLine("Elemento Encontrado");
                            Console.WriteLine(childNode.OuterXml);
                            return;
                        }
                        else
                        {
                            Search2(childNode, attributeName, attributeValue);
                        }
                        childNode = childNode.NextSibling;
                    }
                }
            }

            Console.WriteLine("Elemento no Encontrado");
        }

        void Search2(XmlNode node, string attributeName, string attributeValue)
        {
            XmlNode childNode = node.FirstChild;
            while (childNode != null)
            {
                if (childNode.Attributes != null && childNode.Attributes[attributeName] != null && childNode.Attributes[attributeName].Value == attributeValue)
                {
                    Console.WriteLine("Elemento Encontrado");
                    Console.WriteLine(childNode.OuterXml);
                    return;
                }
                else
                {
                    Search2(childNode, attributeName, attributeValue);
                }
                childNode = childNode.NextSibling;
            }
        }

        string name = "prueba";

        Search("DATOS", "value", "Admin");

    }
}
