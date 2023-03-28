using System.Xml;
using AppDependencies;
public class uwu
{
    static void Main(string[] args)
    {

        FileParser fp = new FileParser();
        fp.CrearBasedeDatos("UwU","INSD12","Harry", "Editado",21);

        string user, password, email;
        int userid;


        fp.Search("UwU");

       
    }
}
