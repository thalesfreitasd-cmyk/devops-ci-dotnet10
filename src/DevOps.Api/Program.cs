using DevOps.Api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<CalculadoraService>();

var app = builder.Build();

app.MapGet("/", () =>
{
    return Results.Ok(new
    {
        mensagem = "API da atividade de Integração Contínua",
        status = "ok"
    });
});

app.MapGet(
    "/api/calculadora/somar/{primeiroNumero:int}/{segundoNumero:int}",
    (
        int primeiroNumero,
        int segundoNumero,
        CalculadoraService calculadora
    ) =>
    {
        var resultado = calculadora.Somar(
            primeiroNumero,
            segundoNumero
        );

        return Results.Ok(new
        {
            primeiroNumero,
            segundoNumero,
            resultado
        });
    }
);

app.Run();
