using ApplicationEndpointsApp.Presentation.Infrastructure.Extensions;

var builder = WebApplication.CreateBuilder();


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddInfrastructure(builder.Configuration);

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// Todo add middleware for global error handling

// app.UseCors();

// app.UseAuthentication();
// app.UseAuthorization();
app.MapControllers();

app.Run();
