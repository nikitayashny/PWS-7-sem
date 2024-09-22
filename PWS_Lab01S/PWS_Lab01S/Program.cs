using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PWS_Lab01
{
    public class Program
    {
        private static int result = 0;

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDistributedMemoryCache();
            builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30); 
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true; 
            });

            var app = builder.Build();

            app.UseStaticFiles();
            app.UseSession();

            app.MapGet("/YNS", async context =>
            {
                await context.Response.WriteAsync(GetResult(context));
            });

            app.MapPost("/YNS", async context =>
            {
                result = int.Parse(context.Request.Form["result"]);
                await context.Response.WriteAsync(GetResult(context));
            });

            app.MapPut("/YNS", async context =>
            {
                var stack = GetStack(context);
                stack.Push(int.Parse(context.Request.Form["add"]));
                SaveStack(context, stack);
                await context.Response.WriteAsync(GetResult(context));
            });

            app.MapDelete("/YNS", async context =>
            {
                var stack = GetStack(context);
                if (stack.Count != 0)
                    stack.Pop();
                SaveStack(context, stack);
                await context.Response.WriteAsync(GetResult(context));
            });

            app.Run();
        }

        private static Stack<int> GetStack(HttpContext context)
        {
            
            if (context.Session.TryGetValue("stack", out var stackBytes))
            {
                var stackJson = System.Text.Encoding.UTF8.GetString(stackBytes);
                return JsonConvert.DeserializeObject<Stack<int>>(stackJson) ?? new Stack<int>();
            }
            return new Stack<int>();
        }

        private static void SaveStack(HttpContext context, Stack<int> stack)
        {
            var stackJson = JsonConvert.SerializeObject(stack);
            context.Session.SetString("stack", stackJson);
        }

        private static string GetResult(HttpContext context)
        {
            int _result = result;
            var stack = GetStack(context);
            if (stack.Count != 0)
                _result += stack.Peek();
            string json = JsonConvert.SerializeObject(new { RESULT = _result });
            return json;
        }
    }
}