namespace FL2023_Assignment1_SKellogg
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.Run();
        }
    }
}