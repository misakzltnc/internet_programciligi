namespace RK2_1.Middleware
{
	public class LoggingMiddleware
	{
		private readonly RequestDelegate _next;

		public LoggingMiddleware(RequestDelegate next)
		{
			_next = next;
		}

		public async Task Invoke(HttpContext context)
		{
			Console.WriteLine("İstek alındı: " + context.Request.Path);
			await _next(context);
			Console.WriteLine("Yanıt gönderildi");
		}
	}
}
