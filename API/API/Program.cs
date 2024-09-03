// minimal API's em C#
// Testar a API
// Rest Client  - Extesão VSCODE
// Postman
// Insomnia

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Funcionalidade = endponits
// Resquisição = URL e método/verbo HTTP
app.MapGet("/", () => "oi!");

app.MapGet("/2", () => "hello 2!");

app.Run();
