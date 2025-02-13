namespace RK2_1._3.Middleware
{
	public class RequestLoggerMiddleware
	{
		private readonly RequestDelegate _next;

		public RequestLoggerMiddleware(RequestDelegate next)
		{
			_next = next;
		}

		public async Task Invoke(HttpContext context)
		{
			//1. Gelen isteği logla
			Console.WriteLine(DateTime.Now + " İstek geldi: " + context.Request.Method + " " + context.Request.Path);

			//2. İsteği bir sonraki middleware'e ilet
			await _next(context);

			//3. Yanıt döndükten sonra logla
			Console.WriteLine(DateTime.Now + " Yanıt gönderildi: " + context.Response.StatusCode);
		}
	}
}
