 var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();

app.MapGet("/", () =>
{
   return "¡Bienvenido a mi primera Web API con ASP.NET Core!";
})

app.MapGet("Euri-Reyes", () =>
{
   return new 
{
    Nombre = "Euri",
    Apellido = "Reyes",
    Edad = "22",
    Matricula = "LR-2024-02098",
    Carrera = "Ing softwera",
};

});
app.Run();