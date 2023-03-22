using System.Xml;
using AppDependencies;
public class uwu
{
    static void Main(string[] args)
    {
        

        // Create a new XmlDocument
        XmlDocument doc = new XmlDocument();

        // Create the root element
        XmlElement raiz = doc.CreateElement("Fields");
        doc.AppendChild(raiz);

        // Create the child elements
        for (int i = 1; i <= 8; i++)
        {
            XmlElement field = doc.CreateElement("Field");
            field.SetAttribute("id", i.ToString());

            XmlElement value = doc.CreateElement("Value");
            value.InnerText = "String " + i.ToString();

            field.AppendChild(value);
            raiz.AppendChild(field);
        }

        // Save the document to a file
        doc.Save("fields.xml");

        // Print the XML document to the console
        Console.WriteLine(doc.OuterXml);
    }
}
