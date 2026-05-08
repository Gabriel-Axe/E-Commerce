using ECommerce.Data;
using ECommerce.Services;
using Microsoft.EntityFrameworkCore;

namespace ECommerce
{
	public class Program
	{
		public static void Main(string[] args)
		{

			var builder = WebApplication.CreateBuilder(args);

			builder.Services.AddDbContext<ECommerceDbContext>();

			builder.Services.AddControllers();
			builder.Services.AddEndpointsApiExplorer();

			var app = builder.Build();

			// var MyCorsPolicy = "_MyCorsPolicy";
			// builder.Services.AddCors(options =>
			// {
			// 	options.AddPolicy(name: MyCorsPolicy,
			// 		policy =>
			// 		{
			// 			policy
			// 			.WithOrigins("http://localhost:5173")
			// 			.AllowAnyHeader()
			// 			.AllowAnyMethod();
			// 		});
			// });

			if (app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Error");
			}

			// app.UseCors(MyCorsPolicy);
			app.UseRouting();
			app.MapControllers();

			app.Run();
		}
	}
}
