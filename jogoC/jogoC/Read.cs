using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoC
{
    class Read
    {
        

        public static Jogo Ler()
        {
            
            String[] lines = System.IO.File.ReadAllLines(@"C:\Users\Mateu\source\repos\Projeto1LP\Narrativa.txt");
            int indice = 0;
            string nome = lines[indice++];
            string desc = lines[indice++];
            Jogo jogo = new Jogo(nome, desc);
            

            string tama = lines[indice++];
            int tam = Convert.ToInt32(tama);
            for(int i = 1; i < tam+1; i++)
            {
                Sala sala = new Sala(i);
                jogo.InsereSala(jogo, sala);
            }
            while (indice<lines.Length)
            {
               
                String[] s = lines[indice++].Split(':') ;
               
                string id = s[0];
                
                string nomeSala = s[1];
                String descSala = lines[indice++];
                String opcoes = lines[indice++];

                Sala sala = new Sala(nomeSala, descSala, opcoes);
                int n = Convert.ToInt32(id);
                sala.Id = n;

                jogo.Preenche(jogo, sala);
            }

            

            return jogo;
            

        }
    }
}
