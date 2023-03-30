using System.Xml;
using AppDependencies;
public class uwu
{
    static async Task Main(string[] args)
    {
        

        FileParser fp = new FileParser();

        await fp.DocumentHandlerTask();

        fp.CrearBasedeDatos("UwU", "INSD12", "Harry", "Editado", 21);

        string user, password, email;
        int userid;
        


        fp.Search("uwu");

    }
}
