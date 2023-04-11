using System.Xml;
using AppDependencies;
public class uwu
{
    static async Task Main(string[] args)
    {


        FileParser fp = new FileParser();

        //fp.CrearBasedeDatos("UwU");
        fp.Global_Name = "UwU";

        //for(int i = 0; i < 10; i++)
        //    fp.AñadirDatos("Nombre Generico"+i, "ISBN Generico" + i, "Autor Generico" + i, "Editor Generico" + i, 123+i);

        string Name, ISBN, Autor, Editor;
        int Paginas;

        fp.Search("Nombre Generico");
    }
}
