using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web
{
    public class Relatorio : IRelatorio
    {
        private readonly ICatalogo catalogo;

        public Relatorio(ICatalogo catalogo)
        {
            this.catalogo = catalogo;
        }

        public async Task imprimir(HttpContext context)
        {

              foreach (var livro in catalogo.GetLivros())
                    {
                        await context.Response.WriteAsync($"{livro.codigo,-10}{livro.nome,-40}{livro.preco.ToString("c"),10}\r\n");

                     }


            }
    }
}
