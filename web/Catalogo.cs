using System;
using System.Collections.Generic;
using System.Text;

namespace web
{
   public class Catalogo : ICatalogo
    {

        public List<Livro> GetLivros(){

            var livros = new List<Livro>();
            livros.Add(new Livro("001", "Quem Mexeu na minha query", 12.50m));
            livros.Add(new Livro("002", "Fique rico com C#", 30.99m));
            livros.Add(new Livro("003", "Java para baixinhos", 25.99m));
            livros.Add(new Livro("004", "Abra a Cabeça C#", 12.50m));

            return livros;
        }
    }
}
