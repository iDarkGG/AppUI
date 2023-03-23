using System.Runtime.CompilerServices;
using System.Xml;
using AppDependencies;
public class uwu
{
    static void Main(string[] args)
    {


        //// Create a new XmlDocument
        //XmlDocument doc = new XmlDocument();

        //// Create the root element
        //XmlElement raiz = doc.CreateElement("Fields");
        //doc.AppendChild(raiz);

        //// Create the child elements
        //for (int i = 1; i <= 8; i++)
        //{
        //    XmlElement field = doc.CreateElement("Field");
        //    field.SetAttribute("id", i.ToString());

        //    XmlElement value = doc.CreateElement("Value");
        //    value.InnerText = "String " + i.ToString();

        //    field.AppendChild(value);
        //    raiz.AppendChild(field);
        //}

        //// Save the document to a file
        //doc.Save("fields.xml");

        //// Print the XML document to the console
        //Console.WriteLine(doc.OuterXml);
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
                    Console.WriteLine("Element found!");
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
                            Console.WriteLine("Element found!");
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

            Console.WriteLine("Element not found.");
        }

        void Search2(XmlNode node, string attributeName, string attributeValue)
        {
            XmlNode childNode = node.FirstChild;
            while (childNode != null)
            {
                if (childNode.Attributes != null && childNode.Attributes[attributeName] != null && childNode.Attributes[attributeName].Value == attributeValue)
                {
                    Console.WriteLine("Element found!");
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

        //CrearBasedeDatos(name);
    }
}
