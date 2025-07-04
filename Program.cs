using StudentTimeProject.Extention;
using StudentTimeProject.Data;
using StudentTimeProject.Data.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.ConfigureDatabase(builder.Configuration);
builder.Services.AddAppServices();

var app = builder.Build();

app.ConfigureExceptionHandler();
app.ConfigureMiddleware();


using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    try
    {
        var context = services.GetRequiredService<ApplicationDbContext>();

        await Seeding.SeedingBoard(context);
    }
    catch (Exception ex)
    {   //시딩이 잘못된 경우우
        Console.WriteLine($"시딩 중 에러 발생: {ex.Message}");
    }
}

app.Run();


