using Lib.Repo;
using Lib.Services;

namespace Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddSingleton<IMemberRepo, MemberJSONRepo >();
            builder.Services.AddSingleton<MemberService>(); 
            
            builder.Services.AddSingleton<IBlogRepo, BlogJSONRepository>();
            builder.Services.AddSingleton<BlogService>();

            builder.Services.AddSingleton<IBoatRepo, BoatJSONRepository>();
            builder.Services.AddSingleton<BoatService>();

            builder.Services.AddSingleton<IBookingRepo, BookingJSONRepository>();
            builder.Services.AddSingleton<BookingService>();
            
            builder.Services.AddSingleton<IEventRepo, EventJSONRepository>();
            builder.Services.AddSingleton<EventService>();

            // Add services to the container.
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
