
using MessageProcessingSystem.DataAccess.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);




builder.Services.AddDataAccess(b =>
    b.UseSqlite(@"Data Source=C:\Users\sdc_a\RiderProjects\MessageProcessingSystem\MessageProcessingSystem.db"));


builder.Services.AddControllers();



var app = builder.Build();


app.UseEndpoints(endpoints =>
    endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}"));


app.MapControllers();
app.Run();