using EmployeesApp.Web.Services;

namespace EmployeesApp.Web
{
    public class Program
    {
        public static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            /*Do not use this when you have a custom message parameter to the class MyServiceAttribute
             * builder.Services.AddScoped<MyServiceAttribute>();
             */
            builder.Services.AddSingleton<IEmployeeService, OtherEmployeeService>();
            var app = builder.Build();
            app.UseStaticFiles();
            app.MapControllers();
            app.Run();
        }
    }
}