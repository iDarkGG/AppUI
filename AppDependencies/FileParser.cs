
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

        public string Global_Name { get; set; }
        private string StringProcesing;

        Misc Misc = new Misc();

        public void CrearAñadirDatos(string Name, string ISBN, string Autor, string Editor, int Paginas)
        {

            string Structure = Name + "," + ISBN + "," + Autor + "," + Editor + "," + Paginas.ToString();

            if (File.Exists(Global_Name))
            {
                using (FileStream fs = new FileStream(Global_Name + ".csv", FileMode.Append, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(Structure);
                    
                }
            }
            else
            {
                using (StreamWriter sw = File.CreateText(Global_Name + ".csv"))
                {
                    sw.WriteLine(Structure);
                }
            }

           
        }


        public bool Search(string Busqueda)
        {
            string? Handler = null;
            List<string[]> SplitHandler = new List<string[]>();

            using (StreamReader sr = File.OpenText(Global_Name + ".csv"))
            {
                while (!sr.EndOfStream)
                {
                    Handler = sr.ReadLine();

                    SplitHandler.Add(Handler.Split(','));

                    /*Diferenciacion de posiciones.
                     0 = Nombre del libro
                     1 = ISBN
                     2 = Autor
                     3 = Editor
                     4 = Numero de Paginas*/
                }

                foreach (var item in SplitHandler)
                {
                    if (item[0].Trim() == Busqueda | item[1].Trim() == Busqueda | item[2].Trim() == Busqueda | item[3].Trim() == Busqueda | item[4].Trim().ToString() == Busqueda)
                    {
                        StringProcesing = item[0].Trim() + "," + item[1].Trim() + "," + item[2].Trim() + "," + item[3].Trim() + "," + Convert.ToInt32(item[4].Trim();
                        Console.WriteLine(Misc.Printer(item[0].Trim(), item[1].Trim(), item[2].Trim(), item[3].Trim(), Convert.ToInt32(item[4].Trim())));
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("No se encontró el libro que busca. Por favor intente con otro o verifique lo que escribió.");
                    }

                }

            }
            return false;

        }

        public void ItemEditor(string Busqueda, string NewName, string NewISBN, string NewAutor, string NewEditor, int NewPages)
        {
            string Content;
            if (Search(Busqueda))
            {
                using (StreamReader sw = File.OpenText(Global_Name+ ".csv"))
                {
                    Content = sw.ReadToEnd();

                    for(int i = 0; i < 5; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                

                                
                                break;
                        }  
                    }


                }
            }

        }
        





    }
}
