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
