using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2RobertoVergaraC
{
    class Program
    {
        static void Main(string[] args)
        {
            Cancion c1 = new Cancion("Lights", "Lights", "Ellie Goulding", "Pop");
            Console.WriteLine(c1.Informacion());
            Console.ReadKey();
        }
    }
}
