using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDependencies
{
    public class Misc
    {


        public string Printer(string Name, string ISBN, string Autor, string Editor, int Paginas)
        {
            return "Nombre: " + Name +
                   "\nISBN: " + ISBN +
                   "\nAutor: " + Autor +
                   "\nEditor: " + Editor +
                   "\nPaginas: " + Paginas;
        }

    }
}
