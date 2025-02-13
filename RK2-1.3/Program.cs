using RK2_1._3.Middleware;

var builder = WebApplication.CreateBuilder(args);

var app  = builder.Build();

//Middleware'i kullanarak loglama ekleyelim
app.UseMiddleware<RequestLoggerMiddleware>();

app.MapGet("/products", () =>
{
	return new List<string> { "Laptop", "Mouse", "Keyboard" };
});

app.Run();