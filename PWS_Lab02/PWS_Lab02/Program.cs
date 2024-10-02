namespace PWS_Lab02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddDistributedMemoryCache();
            builder.Services.AddSession();

            var app = builder.Build();

            app.UseSession();
            app.UseStaticFiles();

            app.MapControllers();

            app.Run();
        }
    }
}