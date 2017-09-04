using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoC
{
    class Sala
    {
        String nome;
        int id;
        String descricao;
        String opcoes;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public String Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public String Opcoes
        {
            get { return opcoes; }
            set { opcoes = value; }
        }


        public Sala(String nome, String descricao, String opcoes)
        {
            this.nome = nome;
            this.descricao = descricao;
            this.opcoes = opcoes;
        }

        public Sala(int id)
        {
            this.id = id;
        }

    }
}
