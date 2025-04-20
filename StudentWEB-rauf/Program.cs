using Microsoft.EntityFrameworkCore;
using StudentWEB_rauf.data;
using StudentWEB_rauf.Profiles;
using StudentWEB_rauf.Repositories.Implementations;
using StudentWEB_rauf.Repositories.Interfaces;
using StudentWEB_rauf.Services.Implementations;
using StudentWEB_rauf.Services.Interfaces;

namespace StudentWEB_rauf
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(ops => ops.UseSqlServer(
            builder.Configuration.GetConnectionString("SQLServerConnectionString")));

            builder.Services.AddAutoMapper(typeof(CustomProfile));
            builder.Services.AddScoped<ICourseRepository,CourseRepository>();  
            builder.Services.AddScoped<ICourseServices,CourseServices>();

            builder.Services.AddScoped<ITeacherRepository, TeacherRepository>();
            builder.Services.AddScoped<ITeacherServices, TeacherServices>();

            builder.Services.AddScoped<IStudentRepository, StudentRepository>();
            builder.Services.AddScoped<IStudentServices, StudentServices>();

            builder.Services.AddScoped<ICourseModuleRepository, CourseModuleRepository>();
            builder.Services.AddScoped<ICourseModuleServices, CourseModuleServices>();
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
        }
    }
}
