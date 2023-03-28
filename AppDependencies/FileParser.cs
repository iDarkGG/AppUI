
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Text.Json.Nodes;
using System.Text.Json;

namespace AppDependencies
{
    public class FileParser
    {


        public void CrearBasedeDatos(string Name, string ISBN, string Autor, string Editor, int Paginas)
        {
           var NodoRaiz = new JsonObject();

           var LibrosNode = new JsonObject();

           var LibroAñadir = new JsonObject();
            LibroAñadir.Add("ISBN", ISBN);
            LibroAñadir.Add("Autor", Autor);
            LibroAñadir.Add("Editor", Editor);
            LibroAñadir.Add("Paginas", Paginas.ToString());

            LibrosNode.Add("LibroDePrueba", LibroAñadir);

            NodoRaiz.Add("Libros", LibrosNode);
            
            var Options = new JsonSerializerOptions() { WriteIndented= true };
            string Libros = JsonSerializer.Serialize(NodoRaiz, Options);

           using (StreamWriter sw = File.CreateText(Name + ".json"))
            {
                sw.WriteLine(Libros);
            }

        }

        public void Search(string Name)
        {
            var jsonString = File.ReadAllText(Name + ".json");

            JsonNode NodoRaiz = JsonNode.Parse(jsonString);


            JsonNode LibroNodo = NodoRaiz["Libros"]["LibroDePrueba"]["ISBN"] = "awadeowo";

            var jsonOptions = new JsonSerializerOptions() { WriteIndented = true };

            

            using (FileStream fs = new FileStream(Name + ".json", FileMode.Append, FileAccess.Write))
            using (StreamWriter sw =new StreamWriter(fs))
            {
                sw.WriteLine(NodoRaiz.ToJsonString(jsonOptions));
            }
            Console.WriteLine(LibroNodo.ToString());
            
           
        }
        
        
    }
}
