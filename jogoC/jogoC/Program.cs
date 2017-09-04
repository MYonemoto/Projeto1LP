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
            Jogo jogo = Read.Ler();

            Console.WriteLine(jogo.Nome);
            Console.WriteLine(jogo.DescricaoInicial+"\n");
            jogo.Imprime(jogo);
            
            


            // opc.Add(op);
            //map.Add(sala1, op);
            //foreach(KeyValuePair<Sala, Opcao> par in map) {
            //Sala sal = par.Key;
            //Opcao opca = par.Value;
            //Console.Write("sala: " + sal.Nome);
            //Console.Write("opcao: " + opca.Nome);
            //Console.Write("destino: " + opca.Destino.Nome);
            //}
            
            


            Console.ReadLine();
        }
    }
}
