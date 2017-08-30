using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoC
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Read.Ler();
            //Console.WriteLine(s[1]);
            List<Opcao> opc = new List<Opcao>();
            Dictionary<Sala, Opcao> map = new Dictionary<Sala, Opcao>();
            Sala sala1 = new Sala("rola", "roola");
            Sala sala2 = new Sala("rolaa", "roolaa");
            Opcao op = new Opcao("direita", sala2);
            opc.Add(op);
            map.Add(sala1, op);
            foreach(KeyValuePair<Sala, Opcao> par in map) {
                Sala sal = par.Key;
                Opcao opca = par.Value;
                Console.Write("sala: " + sal.Nome);
                Console.Write("opcao: " + opca.Nome);
                Console.Write("destino: " + opca.Destino.Nome);
            }
            Console.ReadKey();
        }
    }
}
