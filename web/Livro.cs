﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web
{
    public class Livro
    {
        public Livro(global::System.String codigo, global::System.String nome, global::System.Decimal preco)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.preco = preco;
        }

        public string codigo { get; set; }

        public string nome { get; set; }

        public decimal preco { get; set; }
    }
}
