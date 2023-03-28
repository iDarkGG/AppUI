using System.Xml;
using AppDependencies;
public class uwu
{
    static void Main(string[] args)
    {

        FileParser fp = new FileParser();
        fp.CrearBasedeDatos("UwU");

        string user, password, email;
        int userid;


        fp.Search("UwU", out user, out email, out password, out userid);

        Console.WriteLine(password);
    }
}
