﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoC
{
    class Sala
    {
        string nome;
        string descricao;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Sala(string nome, string descricao)
        {
            this.nome = nome;
            this.descricao = descricao;
        }

    }
}
