using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoC
{
    class Read
    {
        

        public static string[] Ler()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Mateu\source\repos\Projeto1LP\Narrativa.txt");
            return lines;
        }
    }
}
