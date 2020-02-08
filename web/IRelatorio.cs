namespace web
{
    public interface IRelatorio
    {
        Task imprimir(HttpContext context);
    }
}