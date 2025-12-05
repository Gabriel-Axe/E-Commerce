// // var builder = WebApplication.CreateBuilder(args);
// var builder = WebApplication.CreateBuilder();
//
// // Add services to the container.
// // builder.Services.AddRazorComponents()
// // 		.AddInteractiveServerComponents();
// // builder.Services.AddRazorPages();
// // builder.Services.AddControllersWithViews();
//
// var app = builder.Build();
//
// // Configure the HTTP request pipeline.
// // if (!app.Environment.IsDevelopment())
// // {
// // 	app.UseExceptionHandler("/Error");
// // 	app.UseHsts();
// // }
//
// // app.UseHttpsRedirection();
// // app.UseStaticFiles();
//
// // app.UseAuthorization();
//
// app.MapGet("/hi", () => "Hello!");
//
// app.MapDefaultControllerRoute();
// // app.MapRazorPages();
//
// // app.MapRazorComponents<App>()
// // 		.AddInteractiveServerRenderMode();
//
// // app.UseAntiforgery();
//
// app.Run();

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
