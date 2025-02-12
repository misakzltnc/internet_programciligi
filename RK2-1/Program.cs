var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

///  Middleware ekleniyor
app.Use(async (context, next) =>
{
	Console.WriteLine("Ýstek alýndý: " + context.Request.Path);
	await next();
	Console.WriteLine("Yanýt gönderildi");
});

app.MapGet("/", () => "Merhaba ASP.NET CORE!");

//uygulamayý çalýþtýr
app.Run();