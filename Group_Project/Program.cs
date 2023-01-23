using Group_Project.Data;
using Group_Project.Repository.IRepository;
using Group_Project.Repository;
using Microsoft.EntityFrameworkCore;

namespace Group_Project
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews();



			var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? 
				throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
			builder.Services.AddDbContext<MyDbContext>(options =>
			options.UseSqlServer(connectionString));
			builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
			var app = builder.Build();



			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			app.Run();

			//VicksBiz test
			//Test branch
		}
	}
}