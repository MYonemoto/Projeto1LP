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
            Console.WriteLine(jogo.DescricaoInicial);
            Sala sala = Jogo.GetKey(jogo, 1);
            sala.ImprimirSala();


            while (!sala.Id.Equals(11)){
                
                string comando = Console.ReadLine();

                Boolean b = false;
                foreach (Opcao op in jogo.Map[sala])
                {
                    if (op.Nome.Equals(comando))
                    {
                        sala = op.Destino;
                        b = true;
                        sala.ImprimirSala();
                    }
                }
                if (!b)
                {
                    Console.WriteLine("comando invalido");
                }
            }
            Console.ReadLine();
        }
    }
}
