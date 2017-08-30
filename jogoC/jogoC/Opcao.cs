using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoC
{
    class Opcao
    {
        string nome;
        Sala destino;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Sala Destino
        {
            get { return destino; }
            set { destino = value; }
        }

        public Opcao(string nome, Sala destino) {
            this.nome = nome;
            this.destino = destino;
        }

    }
}
