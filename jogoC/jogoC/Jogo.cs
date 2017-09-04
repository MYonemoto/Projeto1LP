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
        Dictionary<Sala, List<Opcao>> map;

        public Jogo(string nome, string descricao)
        {
            this.nome = nome;
            this.descricaoInicial = descricao;
            this.map =  new Dictionary<Sala, List<Opcao>>();
        }

        public void Preenche(Jogo jogo, Sala sala)
        {
            foreach (KeyValuePair<Sala, List<Opcao>> par in jogo.map)
            {
                if (sala.Id.Equals(par.Key.Id))
                {
                    par.Key.Nome = sala.Nome;
                    par.Key.Descricao = sala.Descricao;
                    par.Key.Opcoes = sala.Opcoes;
                }
            }
        }

        public void Imprime(Jogo jogo)
        {
            foreach (KeyValuePair<Sala, List<Opcao>> par in jogo.map)
            {
                Console.WriteLine(par.Key.Id + ": " + par.Key.Nome+ "\n " + par.Key.Descricao+"\n"+par.Key.Opcoes+"\n");
            }
        }

        public void InsereSala(Jogo jogo, Sala sala)
        {
            List<Opcao> opcoes = new List<Opcao>();
            jogo.map.Add(sala, opcoes);
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
         
        public string DescricaoInicial
        {
            get { return descricaoInicial; }
            set { descricaoInicial = value; }
        }


    }
}
