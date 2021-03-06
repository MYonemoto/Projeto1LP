﻿using System;
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
            string nome = lines[indice++];    // nome do jogo
            string desc = lines[indice++];    // descricao inical do jogo
            Jogo jogo = new Jogo(nome, desc);
            

            string tama = lines[indice++];    //numero de salas 
            jogo.Tam = Convert.ToInt32(tama);

            // criando as salas apenas com os IDs  e adicionando keys no hashmap  
            for(int i = 1; i < jogo.Tam+1; i++)
            {
                Sala sala = new Sala(i);
                jogo.InsereSala(jogo, sala);
            }

            //preenchendo as salas com descricao e opcoes  e inserindo no hashmap os values nas suas keys
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

                

                s = lines[indice++].Split(';');
                List<Opcao> adja = new List<Opcao>();
                for(int i = 0; i < s.Length; i++)
                {
                    String[] aux = s[i].Split(' ');
                    String nom = aux[0];
                    String dest = aux[1];
                    int des = Convert.ToInt32(dest);
                    Opcao o = new Opcao(nom, new Sala(des));
                    adja.Add(o);

                }

                jogo.Preenche(jogo, sala, adja);
            }

            

            return jogo;
            

        }
    }
}
