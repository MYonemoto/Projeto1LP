using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoC
{
    class Jogo
    {
        String nome;
        String descricaoInicial;
        int tam;
        Dictionary<Sala, List<Opcao>> map;

        public Jogo(string nome, string descricao)
        {
            this.nome = nome;
            this.descricaoInicial = descricao;
            this.map =  new Dictionary<Sala, List<Opcao>>();
        }

        public void Preenche(Jogo jogo, Sala sala, List<Opcao> adj)
        {
            Sala s = Jogo.GetKey(jogo, sala.Id);
            s.Nome = sala.Nome;
            s.Descricao = sala.Descricao;
            s.Opcoes = sala.Opcoes;
            foreach(Opcao o in adj)
            {
                Sala destino = Jogo.GetKey(jogo, o.Destino.Id);
                if (destino==null)
                {
                    
                    jogo.InsereAdjascencia(jogo, s, o);
                }
                else
                {
                    Opcao aux = new Opcao(o.Nome, destino);
                    jogo.InsereAdjascencia(jogo, s, aux);
                }

            }
            

            
        }

        public static Sala GetKey(Jogo jogo, int id)
        {
            Sala sala = null;
            foreach (KeyValuePair<Sala, List<Opcao>> par in jogo.map)
            {
                if (id.Equals(par.Key.Id))
                {
                    sala = par.Key;
                }
            }
            return sala;
        }
        

        public void Imprime(Jogo jogo)
        {
            foreach (KeyValuePair<Sala, List<Opcao>> par in jogo.map)
            {
                //Console.WriteLine(par.Key.Id + ": " + par.Key.Nome+ "\n " + par.Key.Descricao+"\n"+par.Key.Opcoes+"\n");
                Console.Write("\n" +par.Key.Id + ": ");

                foreach(Opcao o in par.Value)
                {
                    Console.Write(o.Nome + "  " + o.Destino.Id + "; ");
                }
            }
        }

        public void InsereSala(Jogo jogo, Sala sala)
        {
            List<Opcao> opcoes = new List<Opcao>();
            jogo.map.Add(sala, opcoes);
        }

        public void InsereAdjascencia(Jogo jogo, Sala origem, Opcao opcao)
        {
            jogo.map[origem].Add(opcao);
        }

        public Dictionary<Sala, List<Opcao>> Map
        {
            get { return map; }
            set { map = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }

        }

        public int Tam
        {
            get { return tam; }
            set { tam = value; }

        }
        public string DescricaoInicial
        {
            get { return descricaoInicial; }
            set { descricaoInicial = value; }
        }


    }
}
