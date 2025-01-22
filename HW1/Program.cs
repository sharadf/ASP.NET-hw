var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/dev", () =>
{
    return new {
        Profession = "Software engineer",
        Level = "Junior"
    };
});
app.Run();