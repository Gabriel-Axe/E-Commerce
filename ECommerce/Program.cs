using ECommerce.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;


// using ECommerce.Services;
//
// var builder = WebApplication.CreateBuilder(args);
//
// // builder.Services.AddSingleton<ILogger>();
// builder.Services.AddSingleton<UserServices>();
// // builder.Services.AddSingleton<>();
//
// builder.Services.AddControllers();
// builder.Services.AddOpenApi();
//
// var app = builder.Build();
//
// if (app.Environment.IsDevelopment())
// {
// 	// app.UseExceptionHandler("/Error");
// 	app.MapOpenApi();
// }
//
// app.UseRouting();
// app.MapControllers();
// // app.MapStaticAssets(); // WARN: What does this do?
//
// app.Run();

namespace ECommerce
{

	public class Program
	{
		// public void ConfigurationServices(IServiceCollection services)
		// {
		// 	services.AddDbContext<ShopContext>(options =>
		// 			options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))); // NOTE: DefaultConnection is located in appsettings.json
		//
		// 	// services.AddDatabaseDeveloperPageExceptionFilter();
		//
		// 	// services.AddControllersWithViews();
		// }

		public static void Main()
		{

			// var builder = WebApplication.CreateBuilder(args);
			var builder = WebApplication.CreateBuilder();
			builder.Services.AddControllers();
			// NOTE: For using with SQL Server
			// builder.Services.AddDbContext<ShopContext>(options =>
			// 		options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); 
			// NOTE: For using with SQLite
			// builder.Services.AddDbContext<ShopContext>(options =>
			// 		options.UseSqlite("TestDb"));
			// NOTE: For using In Memory
			builder.Services.AddDbContext<ShopContext>(options =>
					options.UseInMemoryDatabase("TestDb"));

			// Add services to the container.
			// builder.Services.AddRazorComponents()
			// 		.AddInteractiveServerComponents();
			// builder.Services.AddRazorPages();
			// builder.Services.AddControllersWithViews();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			// if (!app.Environment.IsDevelopment())
			// {
			// 	app.UseExceptionHandler("/Error");
			// 	app.UseHsts();
			// }

			// app.UseHttpsRedirection();
			// app.UseStaticFiles();

			// app.UseAuthorization();

			// app.MapGet("/hi", () => "Hello!");

			// app.MapDefaultControllerRoute();
			app.MapControllers();
			// app.MapRazorPages();

			// app.MapRazorComponents<App>()
			// 		.AddInteractiveServerRenderMode();

			// app.UseAntiforgery();

			app.Run();
		}
	}

}
