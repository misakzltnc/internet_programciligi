var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

///  Middleware ekleniyor
app.Use(async (context, next) =>
{
	Console.WriteLine("�stek al�nd�: " + context.Request.Path);
	await next();
	Console.WriteLine("Yan�t g�nderildi");
});

app.MapGet("/", () => "Merhaba ASP.NET CORE!");

//uygulamay� �al��t�r
app.Run();