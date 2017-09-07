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
            int tentativa = 8;
            Boolean b;

            sala.ImprimirSala();
            string comando = "";

            while (tentativa > 0){
                comando = Console.ReadLine();
                b = false;

                if (comando.Equals("sair"))
                {
                    Environment.Exit(0);
                }
               
                foreach (Opcao op in jogo.Map[sala])
                {
                    if (op.Nome.Equals(comando))
                    {
                        if (sala.Id.Equals(jogo.Tam-1))
                        {
                            tentativa = 9;
                            Console.Clear();
                        }
                        sala = op.Destino;
                        b = true;                                           
                    }
                }

                if (!b)
                {
                    Console.WriteLine("comando invalido");
                    tentativa++;
                    
                }

                tentativa--;

                if(tentativa == 0)
                {
                    sala = Jogo.GetKey(jogo, jogo.Tam);
                    tentativa = 9;
                    Console.Clear();

                }

                sala.ImprimirSala();
            }

           //Console.ReadLine();
        }
    }
}
