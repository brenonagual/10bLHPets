
using Projeto_Web_Lh_Pets_versão_1;

namespace LH_Pets;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", () => "Projeto Web - LH Pets versão 1");

        app.UseStaticFiles();
        app.MapGet("/index", (HttpContext contexto)=> {
                contexto.Response.Redirect("index.html", false);

        });
        app.MapGet("/listaClientes", (HttpContext contexto) =>
        {


            Banco dba = new Banco();
            contexto.Response.WriteAsync(dba.GetListaString());
        });

        app.Run();
    }
}