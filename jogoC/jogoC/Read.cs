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
            
            String[] lines = System.IO.File.ReadAllLines(@"C:\Users\Geovani\source\repos\Projeto1LP\Narrativa.txt");
            int indice = 0;
            string nome = lines[indice++];
            string desc = lines[indice++];
            Jogo jogo = new Jogo(nome, desc);
            List<Sala> salas = new List<Sala>();
            while (indice!=lines.Length)
            {
                String[] s = lines[indice++].Split(':') ;
                String id = s[0];
                String nomeSala = s[1];
                String descSala = lines[indice++];
                String opcoes = lines[indice++];
                
                Sala sala = new Sala(nomeSala, descSala, opcoes);
                sala.Id = Convert.ToInt32(id);
            
                salas.Add(sala);
                
            }

            

            return jogo;
            

        }
    }
}
